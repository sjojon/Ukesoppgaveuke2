﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ukesoppgaveuke2;

public class Student
{
    public string Name { get; set; }
    public int Age { get; set; }
    public string Kurs { get; set; }

    public Student(string name, int age, string kurs)
    {
        Name = name;
        Age = age;
        Kurs = kurs;
    }
}