﻿namespace DAL.Model
{
    public class Result
    {
        public int status { get; set; }
        public string? message { get; set; }
        public List<Game>? GameList { get; set; }
    }
}