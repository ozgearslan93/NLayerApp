using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace NLayer.Core.DTOs
{
    public class CustomResponseDto<T>
    {
        public T Data { get; set; }

        [JsonIgnore] //clientlere dönmeyeceğiz diye bildirdik
        public int StatusCode { get; set; }

        public List<string> Errors { get; set; }

        public static CustomResponseDto<T> Success( int statusCode,T data) //static factor metot//nesne yaratma işlemini bu sınıf içersinde metotlar seklınde gerceklestırıyoruz
        {
            return new CustomResponseDto<T> { StatusCode = statusCode, Data = data };   
        }
        public static CustomResponseDto<T> Success(int statusCode)
        {
            return new CustomResponseDto<T> { StatusCode = statusCode};
        }
        public static CustomResponseDto<T> Fail(int statusCode,List<string> errors)
        {
            return new CustomResponseDto<T> { StatusCode = statusCode,Errors=errors };
        }
        public static CustomResponseDto<T> Fail(int statusCode, string error)
        {
            return new CustomResponseDto<T> { StatusCode = statusCode, Errors = new List<string> { error }};
        }
    }
}
