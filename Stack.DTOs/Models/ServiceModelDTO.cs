﻿using System;
using System.Collections.Generic;
using System.Text;
namespace Stack.DTOs.Models
{
    public class ServiceModelDTO
    {
        public int Id { get; set; }
        public string NameAR { get; set; }
        public string NameEN { get; set; }
        public string AdminImagePath { get; set; }
        public string UserImagePath { get; set; }
        public int Time { get; set; }
        public float Price { get; set; }
    }
}