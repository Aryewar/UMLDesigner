using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UMLDesigner.Figures;
using UMLDesigner.Figures.Arrows;
using UMLDesigner.Figures.Rectangles;
using System.Text.Json;
using UMLDesigner.Figures.SinglePainter;

namespace UMLDesigner
{
    public class Converter
    {
        private List<AgregationArrow> agregationArrows = new List<AgregationArrow>();
        private List<AlternateAgragationArrow> alternateAgragationArrows = new List<AlternateAgragationArrow>();
        private List<CompositionArrow> compositionArrows = new List<CompositionArrow>();
        private List<AlternateCompositionArrow> alternateCompositionArrows = new List<AlternateCompositionArrow>();
        private List<AssociationArrow> associationArrows = new List<AssociationArrow>();
        private List<InharitanceArrow> inharitanceArrows = new List<InharitanceArrow>();
        private List<RealizationArrow> realizationArrows = new List<RealizationArrow>();
        private List<ClassRectangle> classRectangles = new List<ClassRectangle>();
        private Painter _painter;
        public string SerializeList(List<IFigure> _figures)
        {
            string result = String.Empty;
            ConvertListOfFigures(_figures);
            _painter = Painter.GetPainter();
            result += JsonSerializer.Serialize<List<AgregationArrow>>(agregationArrows) + Environment.NewLine;
            result += JsonSerializer.Serialize<List<AlternateAgragationArrow>>(alternateAgragationArrows) + Environment.NewLine;
            result += JsonSerializer.Serialize<List<CompositionArrow>>(compositionArrows) + Environment.NewLine;
            result += JsonSerializer.Serialize<List<AlternateCompositionArrow>>(alternateCompositionArrows) + Environment.NewLine;
            result += JsonSerializer.Serialize<List<AssociationArrow>>(associationArrows) + Environment.NewLine;
            result += JsonSerializer.Serialize<List<InharitanceArrow>>(inharitanceArrows) + Environment.NewLine;
            result += JsonSerializer.Serialize<List<RealizationArrow>>(realizationArrows) + Environment.NewLine;
            result += JsonSerializer.Serialize<List<ClassRectangle>>(classRectangles) + Environment.NewLine;
            //result += JsonSerializer.Serialize<Painter>(_painter);

            return result;
        }
        private void ConvertListOfFigures(List<IFigure> _figures)
        {
            foreach (IFigure a in _figures)
            {
                switch (a.GetType().ToString())
                {
                    case "AgregationArrow":
                        agregationArrows.Add((AgregationArrow)a);
                        break;
                    case "AlternateAgragationArrow":
                        alternateAgragationArrows.Add((AlternateAgragationArrow)a);
                        break;
                    case "CompositionArrow":
                        compositionArrows.Add((CompositionArrow)a);
                        break;
                    case "AlternateCompositionArrow":
                        alternateCompositionArrows.Add((AlternateCompositionArrow)a);
                        break;
                    case "AssociationArrow":
                        associationArrows.Add((AssociationArrow)a);
                        break;
                    case "InharitanceArrow":
                        inharitanceArrows.Add((InharitanceArrow)a);
                        break;
                    case "RealizationArrow":
                        realizationArrows.Add((RealizationArrow)a);
                        break;
                    case "ClassRectangle":
                        classRectangles.Add((ClassRectangle)a);
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
