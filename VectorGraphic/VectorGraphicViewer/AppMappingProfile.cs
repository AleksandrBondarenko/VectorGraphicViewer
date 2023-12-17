using AutoMapper;
using System.Linq;
using VectorGraphicViewer.ViewModels;
using VectorGraphicViewer.Models;
using System.Windows.Media;
using System.Windows;
using System.Globalization;

namespace VectorGraphicViewer
{
    internal class AppMappingProfile : Profile
    {
        public AppMappingProfile()
        {
            CreateMap<Primitive, PrimitiveVM>()
                .Include<Line, LineVM>()
                .Include<Circle, CircleVM>()
                .Include<Triangle, TriangleVM>();

            CreateMap<Line, LineVM>().ConvertUsing(src => new LineVM(
                StringToPointConverter(src.A), 
                StringToPointConverter(src.B),
                StringToColorConverter(src.Color)));
            CreateMap<Circle, CircleVM>().ConvertUsing(src => new CircleVM(
                StringToPointConverter(src.Center),
                src.Radius,
                src.Filled,
                StringToColorConverter(src.Color)));
            CreateMap<Triangle, TriangleVM>().ConvertUsing(src => new TriangleVM(
                StringToPointConverter(src.A),
                StringToPointConverter(src.B),
                StringToPointConverter(src.C),
                src.Filled,
                StringToColorConverter(src.Color)));
        }

        Point StringToPointConverter(string point)
        {
            var points = point.Split(";").Select(x => double.Parse(x, new NumberFormatInfo { NumberDecimalSeparator = ","})).ToArray();
            return new Point(points[0], points[1]);
        }

        Color StringToColorConverter(string color)
        {
            var colorBytes = color.Split(";").Select(x => byte.Parse(x)).ToArray();
            return Color.FromArgb(colorBytes[0], colorBytes[1], colorBytes[2], colorBytes[3]);
        }
    }
}
