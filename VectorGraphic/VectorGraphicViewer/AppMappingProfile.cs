using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VectorGraphicViewer.ViewModels;
using VectorGraphicViewer.Models;
using System.Windows.Media;
using System.Windows;

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
            var points = point.Split(";").Select(x => double.Parse(x)).ToArray();
            return new Point(points[0], points[1]);
        }

        Color StringToColorConverter(string point)
        {
            var points = point.Split(";").Select(x => byte.Parse(x)).ToArray();
            return Color.FromArgb(points[0], points[1], points[2], points[3]);
        }
    }
}
