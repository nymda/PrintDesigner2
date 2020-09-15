using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections.ObjectModel;
using System.Drawing.Printing;

namespace PrintDesignerMK2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //handles the main canvas
        public Bitmap _DisplayCanvas = new Bitmap(181, 543);
        public List<layer> _layerContainer = new List<layer> { };
        public Graphics _canvasGraphics;
        public int selectedLayerIndex = 0;

        //handles the manipulation joystick thing
        public Bitmap _manipImage = new Bitmap(100, 100);
        public Graphics _manipGraphics;
        public bool isMouseDown = false;
        public Point mousePosRelatedToManipPB = new Point(50, 50);
        public float PIf = (float)Math.PI;
        public float manipAngle = 0;
        public float dx = 0;
        public float dy = 0;

        //handles the shade selection boxes and colours
        public Bitmap shade1 = new Bitmap(20, 20);
        public Graphics shade1graphics;
        public Bitmap shade2 = new Bitmap(20, 20);
        public Graphics shade2graphics;
        public Bitmap shade3 = new Bitmap(20, 20);
        public Graphics shade3graphics;
        public Bitmap shade4 = new Bitmap(20, 20);
        public Graphics shade4graphics;
        public int selectedShade = 1;

        public Pen currentPen = Pens.Black;
        public Brush currentBrush = Brushes.Black;

        private void Form1_Load(object sender, EventArgs e)
        {
            _manipGraphics = Graphics.FromImage(_manipImage);
            _canvasGraphics = Graphics.FromImage(_DisplayCanvas);
            manipulationTimer.Start();
            _manipGraphics.FillRectangle(Brushes.White, 0, 0, 100, 100);
            _manipGraphics.FillEllipse(Brushes.Black, 48, 48, 4, 4);
            _manipGraphics.DrawLine(Pens.Black, 50, 0, 50, 100);
            _manipGraphics.DrawLine(Pens.Black, 0, 50, 100, 50);
            _control_MoveLayer.Image = _manipImage;
            addItemSelect.SelectedIndex = 0;
            refCanvas();

            //this is shit but idc

            shade1graphics = Graphics.FromImage(shade1);
            shade2graphics = Graphics.FromImage(shade2);
            shade3graphics = Graphics.FromImage(shade3);
            shade4graphics = Graphics.FromImage(shade4);

            shade1graphics.FillRectangle(Brushes.Black, 0, 0, 20, 20);
            shade2graphics.FillRectangle(Brushes.Gray, 0, 0, 20, 20);
            shade3graphics.FillRectangle(Brushes.LightGray, 0, 0, 20, 20);
            shade4graphics.FillRectangle(Brushes.White, 0, 0, 20, 20);

            if (selectedShade == 1)
            {
                shade1graphics.DrawRectangle(Pens.Red, 0, 0, 19, 19);
            }
            if (selectedShade == 2)
            {
                shade1graphics.DrawRectangle(Pens.Red, 0, 0, 19, 19);
            }
            if (selectedShade == 3)
            {
                shade1graphics.DrawRectangle(Pens.Red, 0, 0, 19, 19);
            }
            if (selectedShade == 4)
            {
                shade1graphics.DrawRectangle(Pens.Red, 0, 0, 19, 19);
            }

            setShade1.Image = shade1;
            setShade2.Image = shade2;
            setShade3.Image = shade3;
            setShade4.Image = shade4;
        }

        //perform image manipulation (resize / movements) here
        private void manipulationTimer_Tick(object sender, EventArgs e)
        {
            if (isMouseDown)
            {
                int manipForce = (int)Math.Round(Math.Sqrt(Math.Pow((mousePosRelatedToManipPB.X - 50), 2) + Math.Pow((mousePosRelatedToManipPB.Y - 50), 2)));
                if (manipForce > 50)
                {
                    manipForce = 50;
                }
                _manipGraphics.FillRectangle(Brushes.White, 0, 0, 100, 100);
                _manipGraphics.FillEllipse(Brushes.Black, 48, 48, 4, 4);
                _manipGraphics.DrawLine(Pens.Black, 50, 0, 50, 100);
                _manipGraphics.DrawLine(Pens.Black, 0, 50, 100, 50);
                _manipGraphics.DrawLine(Pens.Red, 50, 50, mousePosRelatedToManipPB.X, mousePosRelatedToManipPB.Y);
                float deg = (float)(Math.Atan2(mousePosRelatedToManipPB.X - 50, mousePosRelatedToManipPB.Y - 50));
                deg = deg + -(0.5f * PIf);
                Console.WriteLine(deg);
                dx = (float)Math.Cos(deg);
                dy = (float)Math.Sin(deg);

                if (rbMove.Checked)
                {
                    _layerContainer[selectedLayerIndex].position = new PointF(_layerContainer[selectedLayerIndex].position.X + (dx * (manipForce / 5)), _layerContainer[selectedLayerIndex].position.Y + -(dy * (manipForce / 5)));
                    Console.WriteLine(_layerContainer[selectedLayerIndex].position);
                    _control_MoveLayer.Image = _manipImage;
                }
                else
                {
                    Size ns = calcImgSize((Bitmap)_layerContainer[selectedLayerIndex].pureBitmap, _layerContainer[selectedLayerIndex].sizeOfPureBitmap.Width + (mousePosRelatedToManipPB.X - 50));
                    _layerContainer[selectedLayerIndex].sizeOfPureBitmap = ns;
                    _layerContainer[selectedLayerIndex].image.Dispose();
                    _layerContainer[selectedLayerIndex].image = new Bitmap(_layerContainer[selectedLayerIndex].pureBitmap, ns);
                }
                refCanvas();
            }

        }

        private void CML_Mousedown(object sender, MouseEventArgs e)
        {
            isMouseDown = true;
        }

        private void CML_Mouseup(object sender, MouseEventArgs e)
        {
            isMouseDown = false;
            mousePosRelatedToManipPB = new Point(50, 50);
            int manipForce = (int)Math.Round(Math.Sqrt(Math.Pow((mousePosRelatedToManipPB.X - 50), 2) + Math.Pow((mousePosRelatedToManipPB.Y - 50), 2)));
            _manipGraphics.FillRectangle(Brushes.White, 0, 0, 100, 100);
            _manipGraphics.FillEllipse(Brushes.Black, 48, 48, 4, 4);
            _manipGraphics.DrawLine(Pens.Black, 50, 0, 50, 100);
            _manipGraphics.DrawLine(Pens.Black, 0, 50, 100, 50);
            _manipGraphics.DrawLine(Pens.Red, 50, 50, mousePosRelatedToManipPB.X, mousePosRelatedToManipPB.Y);
            _control_MoveLayer.Image = _manipImage;
        }

        private void CML_Mouseleave(object sender, EventArgs e)
        {
            isMouseDown = false;
            mousePosRelatedToManipPB = new Point(50, 50);
        }

        private void CML_Mousemove(object sender, MouseEventArgs e)
        {
            if (isMouseDown)
            {
                mousePosRelatedToManipPB = new Point(e.X, e.Y);
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            layer l = new layer(_layerContainer);
            _layerContainer.Add(l);
            refLayerMon();
        }

        public void refLayerMon()
        {
            _layers.Items.Clear();
            int x = 0;
            Console.WriteLine("---");
            foreach(layer l in _layerContainer)
            {
                Console.WriteLine(l.name);
                if(x == selectedLayerIndex)
                {
                    _layers.Items.Add(new colourListBoxItem(Color.Red, l.name));
                }
                else
                {
                    _layers.Items.Add(new colourListBoxItem(Color.Black, l.name));
                }
                x++;
            }
            Console.WriteLine("---");
        }

        public void refCanvas()
        {
            _canvasGraphics.FillRectangle(Brushes.White, 0, 0, _DisplayCanvas.Width, _DisplayCanvas.Height);
            foreach (layer l in _layerContainer)
            {
                _canvasGraphics.DrawImage(l.image, l.position);
            }
            _dispCanvas.Image = _DisplayCanvas;
        }

        public void refShadeSelecters()
        {
            shade1graphics.FillRectangle(Brushes.Black, 0, 0, 20, 20);
            shade2graphics.FillRectangle(Brushes.Gray, 0, 0, 20, 20);
            shade3graphics.FillRectangle(Brushes.LightGray, 0, 0, 20, 20);
            shade4graphics.FillRectangle(Brushes.White, 0, 0, 20, 20);
            
            if (selectedShade == 1)
            {
                shade1graphics.DrawRectangle(Pens.Red, 0, 0, 19, 19);
                currentPen = Pens.Black;
                currentBrush = Brushes.Black;
            }
            if (selectedShade == 2)
            {
                shade2graphics.DrawRectangle(Pens.Red, 0, 0, 19, 19);
                currentPen = Pens.Gray;
                currentBrush = Brushes.Gray;
            }
            if (selectedShade == 3)
            {
                shade3graphics.DrawRectangle(Pens.Red, 0, 0, 19, 19);
                currentPen = Pens.LightGray;
                currentBrush = Brushes.LightGray;
            }
            if (selectedShade == 4)
            {
                shade4graphics.DrawRectangle(Pens.Red, 0, 0, 19, 19);
                currentPen = Pens.White;
                currentBrush = Brushes.White;
            }

            setShade1.Image = shade1;
            setShade2.Image = shade2;
            setShade3.Image = shade3;
            setShade4.Image = shade4;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            _layerContainer.RemoveAt(selectedLayerIndex);
            refLayerMon();
            refCanvas();
        }

        private void _layers_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedLayerIndex = _layers.SelectedIndex;
            refLayerMon();
        }

        private void addItemBtn_Click(object sender, EventArgs e)
        {
            //handling adding items
            layer l = new layer(_layerContainer);

            int newItemX = (int)addItemSize_X.Value;
            int newItemY = (int)addItemSize_Y.Value;

            if (addItemSelect.SelectedIndex == 0)
            {
                //image
                using (OpenFileDialog dlg = new OpenFileDialog())
                {
                    dlg.Title = "Open Input File";

                    if (dlg.ShowDialog() == DialogResult.OK)
                    {
                        Bitmap loaded = (Bitmap)Image.FromFile(dlg.FileName);
                        l.image = new Bitmap(loaded.Width, loaded.Height);
                        l.pureBitmap = (Bitmap)loaded.Clone();
                        l.sizeOfPureBitmap = new Size(l.pureBitmap.Width, l.pureBitmap.Height);
                        l.g = Graphics.FromImage(l.image);
                        l.g.DrawImage(loaded, 0, 0);
                    }
                }
            }
            if (addItemSelect.SelectedIndex == 1)
            {
                //string
            }
            if (addItemSelect.SelectedIndex == 2)
            {
                //trans square
                l.g.DrawRectangle(currentPen, 0, 0, newItemX, newItemY);
                l.pureBitmap = (Bitmap)l.image.Clone();
                l.sizeOfPureBitmap = new Size(l.pureBitmap.Width, l.pureBitmap.Height);
            }
            if (addItemSelect.SelectedIndex == 3)
            {
                //filled square
                l.g.FillRectangle(currentBrush, 0, 0, newItemX, newItemY);
                l.pureBitmap = (Bitmap)l.image.Clone();
                l.sizeOfPureBitmap = new Size(l.pureBitmap.Width, l.pureBitmap.Height);
            }
            if (addItemSelect.SelectedIndex == 4)
            {
                //trans circle
                l.g.DrawEllipse(currentPen, 0, 0, newItemX, newItemY);
                l.pureBitmap = (Bitmap)l.image.Clone();
                l.sizeOfPureBitmap = new Size(l.pureBitmap.Width, l.pureBitmap.Height);
            }
            if (addItemSelect.SelectedIndex == 5)
            {
                //filled circle
                l.g.FillEllipse(currentBrush, 0, 0, newItemX, newItemY);
                l.pureBitmap = (Bitmap)l.image.Clone();
                l.sizeOfPureBitmap = new Size(l.pureBitmap.Width, l.pureBitmap.Height);
            }

            _layerContainer.Add(l);
            selectedLayerIndex = _layers.Items.Count;
            refLayerMon();
            refCanvas();
        }

        private void layersLbDrawItem(object sender, DrawItemEventArgs e)
        {
            if(e.Index != -1)
            {
                colourListBoxItem item = _layers.Items[e.Index] as colourListBoxItem;
                if (item != null)
                {
                    e.Graphics.DrawString(item.Message, _layers.Font, new SolidBrush(item.ItemColor), 0, e.Index * _layers.ItemHeight);
                }
                else
                {

                }
            }
        }

        private void btnLayerUp_Click(object sender, EventArgs e)
        {
            layer tmp = _layerContainer[selectedLayerIndex];
            int newPos = selectedLayerIndex - 1;
            _layerContainer.RemoveAt(selectedLayerIndex);
            _layerContainer.Insert(newPos, tmp);
            selectedLayerIndex--;
            refLayerMon();
            refCanvas();
        }

        private void btnLayerDown_Click(object sender, EventArgs e)
        {
            layer tmp = _layerContainer[selectedLayerIndex];
            int newPos = selectedLayerIndex + 1;
            _layerContainer.RemoveAt(selectedLayerIndex);
            _layerContainer.Insert(newPos, tmp);
            selectedLayerIndex++;
            refLayerMon();
            refCanvas();
        }

        private void shadeSelect_Click(object sender, EventArgs e)
        {
            string name = (sender as PictureBox).Name;
            if(name == "setShade1")
            {
                selectedShade = 1;
            }
            if (name == "setShade2")
            {
                selectedShade = 2;
            }
            if (name == "setShade3")
            {
                selectedShade = 3;
            }
            if (name == "setShade4")
            {
                selectedShade = 4;
            }
            refShadeSelecters();
        }

        private void btnPrintFinalImg_Click(object sender, EventArgs e)
        {
            PrintDocument pd = new PrintDocument();
            pd.PrintPage += delegate (object sender1, PrintPageEventArgs e1)
            {
                e1.Graphics.DrawImage(_dispCanvas.Image, new Point(0, 0));
                pd.PrinterSettings.PrinterName = "POS58 Printer";
            };
            pd.Print();
        }

        private void clrButton_Click(object sender, EventArgs e)
        {
            foreach(layer l in _layerContainer)
            {
                l.image.Dispose();
            }
            _layerContainer.Clear();
            refLayerMon();
            refCanvas();
        }

        public Size calcImgSize(Bitmap b, int width)
        {
            int sourceWidth = b.Width;
            int sourceHeight = b.Height;
            float nPercent = ((float)width / (float)sourceWidth);
            int destWidth = (int)(sourceWidth * nPercent);
            int destHeight = (int)(sourceHeight * nPercent);

            return new Size(destWidth, destHeight);
        }
    }

    public class layer
    {
        public Image pureBitmap { get; set; }
        public Size sizeOfPureBitmap { get; set; }
        public Bitmap image { get; set; }
        public Graphics g { get; set; }
        public PointF position { get; set; }
        public string name { get; set; }
        public layer(List<layer> layerContainerReference)
        {
            image = new Bitmap(500, 500);
            g = Graphics.FromImage(image);
            position = new Point(0, 0);
            name = "Layer " + (layerContainerReference.Count() + 1);
        }
    }
    public class colourListBoxItem
    {
        public colourListBoxItem(Color c, string m)
        {
            ItemColor = c;
            Message = m;
        }
        public Color ItemColor { get; set; }
        public string Message { get; set; }
    }
}
