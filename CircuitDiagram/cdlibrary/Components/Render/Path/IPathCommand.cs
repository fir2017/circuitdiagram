﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Media;
using System.Windows;
using System.IO;

namespace CircuitDiagram.Components.Render.Path
{
    public interface IPathCommand
    {
        Point End { get; }
        CommandType Type { get; }
        void Draw(StreamGeometryContext dc, Vector startOffset);
        string Shorthand(Point offset, Point previous);
        void Write(BinaryWriter writer);
        void Read(BinaryReader reader);
    }
}