using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Security.Policy;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Minecraft_Pixel_Art {
    public partial class Main : Form {
        [DllImport("user32.dll")]
        static extern void keybd_event(byte bVk, byte bScan, uint dwFlags, int dwExtraInfo);

        [DllImport("user32.dll")]
        private static extern int MapVirtualKey(int wCode, int wMapType);

        public const int KEYEVENTF_KEYDOWN = 0x0000; // New definition
        public const int KEYEVENTF_EXTENDEDKEY = 0x0001; // Key down flag
        public const int KEYEVENTF_KEYUP = 0x0002; // Key up flag
        public const int VK_RETURN = 0x0D; // ENTER key code
        public const int VK_LCONTROL = 0xA2; // Left Control key code
        public const int VK_T = 0x54; // T key code
        public const int VK_V = 0x56; // V key code

        public Main() {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) {
            loadBlocks();
            getPixel(pictureBox1.Image);
            foreach (string c in optimizedList) {
                if (c != null)
                    richTextBox1.AppendText(c + Environment.NewLine);
            }

            //richTextBox2.Text = genOneCommand();

            richTextBox2.Text = genOneCommand(0);

            //Thread.Sleep(3000);

            //timerCommand = 0;
            //timer1.Enabled = true;
        }

        private int posX = 10, posZ = 10, posY = 200;
        private string[] concrete;
        private string[] terracotta;
        private Color[] concreteColor;
        private Color[] terracottaColor;
        private string[,] pixel;
        private string[] optimizedList;
        private bool fromMe = true;

        private void loadBlocks() {
            string[] concreteList = Regex.Split(Properties.Resources.Concrete, Environment.NewLine);
            string[] terracottaList = Regex.Split(Properties.Resources.Terracotta, Environment.NewLine);
            concrete = new string[concreteList.Length];
            terracotta = new string[terracottaList.Length];
            concreteColor = new Color[concreteList.Length];
            terracottaColor = new Color[terracottaList.Length];
            for (int i = 0; i < concreteList.Length; i++) {
                concrete[i] = concreteList[i].Split(' ')[0].Trim();
                concreteColor[i] = ColorTranslator.FromHtml(concreteList[i].Split(' ')[1].Trim());
            }
            for (int i = 0; i < terracottaList.Length; i++) {
                terracotta[i] = terracottaList[i].Split(' ')[0].Trim();
                terracottaColor[i] = ColorTranslator.FromHtml(terracottaList[i].Split(' ')[1].Trim());
            }
        }

        private void getPixel(Image image) {
            Bitmap bitmap = new Bitmap(image);
            MessageBox.Show(bitmap.GetPixel(0, 0).ToString());
            pixel = new string[image.Width, image.Height];
            for (int x = 0; x < image.Width; x++) {
                for (int y = 0; y < image.Height; y++) {
                    Color bitmapColor = bitmap.GetPixel(x, y);
                    if (bitmapColor.A != 0)
                        pixel[x, y] = compareColor(bitmapColor);
                }
            }
            optimizeColor(image);
        }

        private string compareColor(Color color) {
            int min = 255;
            string bestPick = "";
            for (int c = 0; c < concrete.Length; c++) {
                Color cc = concreteColor[c];
                int similarity = (Math.Abs(color.R - cc.R) + Math.Abs(color.G - cc.G) + Math.Abs(color.B - cc.B)) / 3;
                if (similarity < min) {
                    min = similarity;
                    bestPick = concrete[c];
                }
            }
            for (int t = 0; t < terracotta.Length; t++) {
                Color ct = terracottaColor[t];
                int similarity = (Math.Abs(color.R - ct.R) + Math.Abs(color.G - ct.G) + Math.Abs(color.B - ct.B)) / 3;
                if (similarity < min) {
                    min = similarity;
                    bestPick = terracotta[t];
                }
            }
            return bestPick;
        }

        
        int timerCommand = 0;
        private void timer1_Tick(object sender, EventArgs e) {
            sendCommand(optimizedList[timerCommand]);
            timerCommand++;

            if (timerCommand > optimizedList.Length)
                timer1.Enabled = false;
        }

        private void optimizeColor(Image image) {
            optimizedList = new string[image.Width * image.Height];
            int command = 0;
            string playerLoc = fromMe ? "~" : "";

            for (int x = 0; x < image.Width; x++) {
                int continued = 0;
                string block = "";
                for (int y = 0; y < image.Height - 1; y++) {
                    if (pixel[x, y].Equals(pixel[x, y + 1])) {
                        block = pixel[x, y];
                        continued++;
                    } else {
                        if (continued == 0)
                            optimizedList[command++] = $"/setblock {playerLoc}{posX + y} {playerLoc}{posY - x} {playerLoc}{posZ} minecraft:{block} replace";
                        else
                            optimizedList[command++] = $"/fill {playerLoc}{posX + y - continued} {playerLoc}{posY - x} {playerLoc}{posZ} {playerLoc}{posX + y} {playerLoc}{posY - x} {playerLoc}{posZ} minecraft:{block} replace";
                        block = pixel[x, y + 1];
                        continued = 0;
                    }
                }
            }
        }

        
        private void sendKey(Keys key) {
            keybd_event((byte)key, (byte)MapVirtualKey((int)key, 0), 0, 0);
            keybd_event((byte)key, 0, KEYEVENTF_KEYUP, 0);
        }
        private void mutiSendKey(Keys key1, Keys key2) {
            keybd_event((byte)key1, (byte)MapVirtualKey((int)key1, 0), KEYEVENTF_KEYDOWN, 0);
            keybd_event((byte)key2, (byte)MapVirtualKey((int)key2, 0), KEYEVENTF_KEYDOWN, 0);
            keybd_event((byte)key1, (byte)MapVirtualKey((int)key1, 0), KEYEVENTF_KEYUP, 0);
            keybd_event((byte)key2, (byte)MapVirtualKey((int)key2, 0), KEYEVENTF_KEYUP, 0);
        }

        private void sendCommand(string command) {
            Clipboard.SetText(command);
            sendKey(Keys.T);
            Thread.Sleep(100);
            SendKeys.SendWait(command);
            //mutiSendKey(Keys.Control, Keys.V);
            Thread.Sleep(100);
            //SendKeys.SendWait("~");
            //sendKey(VK_RETURN);
            keybd_event(VK_RETURN, (byte)MapVirtualKey(VK_RETURN, 0), 0, 0);
            keybd_event(VK_RETURN, 0, KEYEVENTF_KEYUP, 0);
            Thread.Sleep(100);
        }

        private string genOneCommand() {
            string oneCommand = "/summon FallingSand ~ ~1 ~ {Block:redstone_block,Time:1";
            int call = optimizedList.Length - 2;
            for (int c = 0; c < optimizedList.Length - 2; c++) {
                if (optimizedList[c + 2] == null) {
                    call = c;
                    break;
                } else {
                    oneCommand += $"Riding:{{id:FallingSand,Block:command_block,Time:1,TileEntityData: {{{optimizedList[c]}}},";
                }
            }
            oneCommand += $"Riding:{{id:FallingSand,Block:command_block,Time:1,TileEntityData: {{{optimizedList[call]}}}";


            //oneCommand += riding(0);
            oneCommand += string.Concat(Enumerable.Repeat("}", call + 2));
            return oneCommand;
        }

        private string riding(int num) {
            if (num < optimizedList.Length) {

                return $"Riding:{{id:FallingSand,Block:command_block,Time:1,TileEntityData: {{{optimizedList[num]}}},{riding(num + 1)}";
            } else
                return $"Riding:{{id:FallingSand,Block:command_block,Time:1,TileEntityData: {{{optimizedList[num]}}}";
        }

        private string genOneCommand(int starting) {
            string oneCommand = "/summon FallingSand ~ ~1 ~ {Block:redstone_block,Time:1,";
            int count = 0;
            bool continued = false;
            while (true) {
                if (count >= optimizedList.Length - 1)
                    break;
                if (oneCommand.Length + optimizedList[count + 1].Length >= 32000) {
                    continued = true;
                    break;
                } else {
                    oneCommand += $",Riding:{{id:FallingSand,Block:command_block,Time:1,TileEntityData: {{Command:{optimizedList[count++]}}}";
                }
            }
            oneCommand += string.Concat(Enumerable.Repeat("}", count + 1));
            return oneCommand;
        }
    }
}
