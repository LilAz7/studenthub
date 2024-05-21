using System;
using System.Collections.Generic;


namespace Module;

public partial class Student
{
    public int Id { get; set; }

    public string Login { get; set; } = null!;

    public string Password { get; set; } = null!;

    public string Fio { get; set; } = null!;
}
