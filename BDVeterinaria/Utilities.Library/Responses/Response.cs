﻿namespace Utilities.Library.Responses
{
    public class Response<T>
    {
        public bool IsSuccess { get; set; }
        public string Message { get; set; }
        public int TruePasswordHash { get; set; }
        public T Result { get; set; }
    }
}
