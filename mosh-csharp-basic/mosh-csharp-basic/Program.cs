﻿using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.IO; //Used for file and FileInfo Class
using mosh_csharp_basic.primitive;
using mosh_csharp_basic.nonprimitive;
using mosh_csharp_basic.nonprimitive.classes;
using mosh_csharp_basic.control_flow;
using mosh_csharp_basic.control_flow.condition_exercises;
using mosh_csharp_basic.control_flow.Iteration_statements;
using mosh_csharp_basic.arrys_and_lists;
using mosh_csharp_basic.working_with_dates;
using mosh_csharp_basic.working_with_files;
using mosh_csharp_basic.working_with_files.file_and_fileInfo;
using mosh_csharp_basic.working_with_text;
using mosh_csharp_basic.working_with_text.exercise_with_working_with_text;
using mosh_csharp_basic.working_with_text.procedural_programming;

namespace mosh_csharp_basic
{
    class Program
    {
        static void Main(string[] args)
        {
            FileAndFileInfo fileAndFile = new FileAndFileInfo();
            fileAndFile.GetFileAndFileInfo();
        }

    }
}
