using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UMLDesigner.Figures;
using UMLDesigner.Figures.Rectangles;
using UMLDesigner.Figures.SinglePainter;

namespace UMLDesigner
{
    public partial class RightClickDialog:Form
    {
        private IFigure _figure;
        private Painter _painter;
        private ClassDialogForm _classDialogForm;

        public RightClickDialog()
        {
            InitializeComponent();
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
        }

        public void OpenPropertiesDialog(IFigure figure,Point position)
        {
            this.Location = position;
            _figure = figure;
            _painter = Painter.GetPainter();
            this.ShowDialog();
        }

        private void ButtonRemove_Click(object sender, EventArgs e)
        {
            List<IFigure> removeFigures = new List<IFigure>();
            foreach(IFigure arrow in _figure.Links)
            {
                foreach (IFigure figure in _painter.Figures)
                {
                    if (figure == arrow)
                    {
                        removeFigures.Add(arrow);
                    }
                }
            }
            foreach (IFigure removeItem in removeFigures)
            {
                for (int i = 0; i < removeItem.Links.Count; ++i)
                {

                    removeItem.Links[i].Links.Remove(removeItem);
                }
                _painter.Figures.Remove(removeItem);
            }
            _painter.Figures.Remove(_figure);
            _painter.RemovedFigures.Add(_figure);
            _painter.Clear();
            _painter.UpdatePictureBox();

            foreach (IFigure a in _painter.Figures)
            {
                a.Draw();
            }
            _painter.SetMainBitmap();
            this.Close();
        }

        private void PropertiesDialog_Load(object sender, EventArgs e)
        {
            _classDialogForm = new ClassDialogForm();
        }

        private void ButtonProperties_Click(object sender, EventArgs e)
        {
            ClassRectangle rect = (ClassRectangle)_figure;
            _classDialogForm.OpenCurrentFigure(rect);
            this.Close();
        }

        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
