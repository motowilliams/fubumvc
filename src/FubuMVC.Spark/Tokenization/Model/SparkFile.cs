﻿using System;
using System.Collections.ObjectModel;
using System.IO;
using FubuCore;

namespace FubuMVC.Spark.Tokenization.Model
{
    public class SparkFile
    {
        public SparkFile(string path, string root, string origin)
        {
            Path = path;
            Root = root;
            Origin = origin;
        }

        public string Path { get; private set; }
        public string Root { get; private set; }
        public string Origin { get; private set; }
        
        public Type ViewModelType { get; set; }
        public string Namespace { get; set; }
    }

    public static class SparkFileHelper
    {
        public static string RelativePath(this SparkFile file)
        {
            return file.Path.PathRelativeTo(file.Root);
        }

        public static string Name(this SparkFile file)
        {
            return Path.GetFileNameWithoutExtension(file.Path);
        }
    }

    public class SparkFiles : Collection<SparkFile> { }
}