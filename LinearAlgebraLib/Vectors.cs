using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.VisualBasic;

namespace LinearAlgebraLibrary
{
    // const int BeginningIndex = 0;
    public class Vector<T>
    {
        public T[] values;
        public Vector(T[] numbers) {
            
            if(numbers.All(value => value is int || value is double || value is short || value is long || value is float || value is ImaginaryNumbers.ImaginaryNumber || value is ImaginaryNumbers.ComplexNumber)) 
            {
                values = numbers; 
            }
            else
            {
                throw new Exception("Invalid data types present in Vector.");
            }
             
        }

        // Func<ImaginaryNumbers.ComplexNumber, ImaginaryNumbers.ComplexNumber, ImaginaryNumbers.ComplexNumber> complexMultiplication = (ImaginaryNumbers.ComplexNumber a, ImaginaryNumbers.ComplexNumber b) => 
        // {
            
        //     return a * b;
        // };

        // Func<ImaginaryNumbers.ComplexNumber, ImaginaryNumbers.ImaginaryNumber, ImaginaryNumbers.ComplexNumber> complexImaginaryMultiplication = (ImaginaryNumbers.ComplexNumber a, ImaginaryNumbers.ImaginaryNumber b) => 
        // {
            
        //     return a * b;
        // };
        // Func<ImaginaryNumbers.ImaginaryNumber, ImaginaryNumbers.ComplexNumber, ImaginaryNumbers.ComplexNumber> imaginaryComplexMultiplication = (ImaginaryNumbers.ImaginaryNumber a, ImaginaryNumbers.ComplexNumber b) => 
        // {
            
        //     return a * b;
        // };
        // Func<ImaginaryNumbers.ImaginaryNumber, ImaginaryNumbers.ImaginaryNumber, ImaginaryNumbers.ImaginaryNumber> imaginaryMultiplication = (ImaginaryNumbers.ImaginaryNumber a, ImaginaryNumbers.ImaginaryNumber b) => 
        // {
            
        //     return a * b;
        // };
        // Func<ImaginaryNumbers.ImaginaryNumber, double, ImaginaryNumbers.ImaginaryNumber> imaginaryNumberMultiplication = (ImaginaryNumbers.ImaginaryNumber a, double b) => 
        // {
            
        //     return a * b;
        // };
        // Func<double, ImaginaryNumbers.ImaginaryNumber, ImaginaryNumbers.ImaginaryNumber> numberImaginaryMultiplication = (double a, ImaginaryNumbers.ImaginaryNumber b) => 
        // {
            
        //     return a * b;
        // };

        // Func<double, ImaginaryNumbers.ComplexNumber, ImaginaryNumbers.ComplexNumber> doubleComplexMultiplication = (double a, ImaginaryNumbers.ComplexNumber b) => 
        // {
            
        //     return a * b;
        // };
        // Func<ImaginaryNumbers.ComplexNumber, double, ImaginaryNumbers.ComplexNumber> ComplexDoubleMultiplication = (ImaginaryNumbers.ComplexNumber a, double b) => 
        // {
            
        //     return a * b;
        // };
        // Func<ImaginaryNumbers.ComplexNumber, double, ImaginaryNumbers.ComplexNumber> ComplexDoubleMultiplication = (ImaginaryNumbers.ComplexNumber a, double b) => 
        // {
            
        //     return a * b;
        // };
        // Func<ImaginaryNumbers.ImaginaryNumber, double, ImaginaryNumbers.ComplexNumber> ComplexDoubleMultiplication = (ImaginaryNumbers.ComplexNumber a, double b) => 
        // {
            
        //     return a * b;
        // };

        public static ImaginaryNumbers.ComplexNumber imaginaryDotProduct(Vector<T> A, Vector<T> B, int Index, ImaginaryNumbers.ComplexNumber cn) {
            if(A.values.Length != B.values.Length) {
                throw new ArithmeticException("Dot-Products require Vectors of the same size.");
            }
            else if(Index == A.values.Length-1) {
               
               switch(A.values[Index], B.values[Index]) {
                    case(ImaginaryNumbers.ImaginaryNumber, ImaginaryNumbers.ImaginaryNumber):
                        //cn += A.imaginaryMultiplication((ImaginaryNumbers.ImaginaryNumber)A.values[Index], (ImaginaryNumbers.ImaginaryNumber)B.values[Index]);
                        cn += (dynamic)A.values[Index]! * (dynamic)B.values[Index]!;
                        return cn;
                    case(ImaginaryNumbers.ImaginaryNumber, ImaginaryNumbers.ComplexNumber):
                        //cn += A.imaginaryComplexMultiplication((ImaginaryNumbers.ImaginaryNumber)A.values[Index], (ImaginaryNumbers.ComplexNumber)B.values[Index]);
                        cn += (dynamic)A.values[Index]!* B.values[Index];
                        return cn;
                    case(ImaginaryNumbers.ComplexNumber, ImaginaryNumbers.ImaginaryNumber):
                        //cn += A.complexImaginaryMultiplication((ImaginaryNumbers.ComplexNumber)A.values[Index], (ImaginaryNumbers.ImaginaryNumber)B.values[Index]);
                        cn += (dynamic)A.values[Index]! * (dynamic)B.values[Index]!;
                        return cn;
                    case(ImaginaryNumbers.ComplexNumber, ImaginaryNumbers.ComplexNumber):
                        //cn += A.complexMultiplication((ImaginaryNumbers.ComplexNumber)A.values[Index], (ImaginaryNumbers.ComplexNumber)B.values[Index]);
                        cn += (dynamic)A.values[Index]! * (dynamic)B.values[Index]!;
                        return cn;
                    case(double, ImaginaryNumbers.ComplexNumber):
                    case(int, ImaginaryNumbers.ComplexNumber):
                    case(float, ImaginaryNumbers.ComplexNumber):
                    case(short, ImaginaryNumbers.ComplexNumber):
                    case(long, ImaginaryNumbers.ComplexNumber):
                        //cn += A.doubleComplexMultiplication((double)A.values[Index], (ImaginaryNumbers.ComplexNumber)B.values[Index]);
                        cn += Convert.ToDouble(A.values[Index]) * (dynamic)B.values[Index]!;
                        return cn;
                    case(ImaginaryNumbers.ComplexNumber, double):
                    case(ImaginaryNumbers.ComplexNumber, int):
                    case(ImaginaryNumbers.ComplexNumber, short):
                    case(ImaginaryNumbers.ComplexNumber, long):
                    case(ImaginaryNumbers.ComplexNumber, float):
                        //cn += A.doubleComplexMultiplication((double)A.values[Index], (ImaginaryNumbers.ComplexNumber)B.values[Index]);
                        cn += (dynamic)A.values[Index]! * Convert.ToDouble(B.values[Index]);
                        return cn;
                    case(ImaginaryNumbers.ImaginaryNumber, double):
                    case(ImaginaryNumbers.ImaginaryNumber, int):
                    case(ImaginaryNumbers.ImaginaryNumber, float):
                    case(ImaginaryNumbers.ImaginaryNumber, short):
                    case(ImaginaryNumbers.ImaginaryNumber, long):
                        cn += (dynamic)A.values[Index]! * Convert.ToDouble(B.values[Index]);
                        return cn;
                    case(double, ImaginaryNumbers.ImaginaryNumber):
                    case(int, ImaginaryNumbers.ImaginaryNumber):
                    case(long, ImaginaryNumbers.ImaginaryNumber):
                    case(short, ImaginaryNumbers.ImaginaryNumber):
                    case(float, ImaginaryNumbers.ImaginaryNumber):
                        cn += (dynamic)A.values[Index]! * (dynamic)B.values[Index]!;
                        return cn;
                    default:
                        cn += Convert.ToDouble(A.values[Index]) + Convert.ToDouble(B.values[Index]);
                        return cn;

                };
            }
            else
            {
                switch(A.values[Index], B.values[Index]) {
                    case(ImaginaryNumbers.ImaginaryNumber, ImaginaryNumbers.ImaginaryNumber):
                        //cn += A.imaginaryMultiplication((ImaginaryNumbers.ImaginaryNumber)A.values[Index], (ImaginaryNumbers.ImaginaryNumber)B.values[Index]);
                        cn += (dynamic)A.values[Index]! * (dynamic)B.values[Index]!;
                        return imaginaryDotProduct(A, B, Index+1, cn);
                    case(ImaginaryNumbers.ImaginaryNumber, ImaginaryNumbers.ComplexNumber):
                        //cn += A.imaginaryComplexMultiplication((ImaginaryNumbers.ImaginaryNumber)A.values[Index], (ImaginaryNumbers.ComplexNumber)B.values[Index]);
                        cn += (dynamic)A.values[Index]! * (dynamic)B.values[Index]!;
                        return imaginaryDotProduct(A, B, Index+1, cn);
                    case(ImaginaryNumbers.ComplexNumber, ImaginaryNumbers.ImaginaryNumber):
                        //cn += A.complexImaginaryMultiplication((ImaginaryNumbers.ComplexNumber)A.values[Index], (ImaginaryNumbers.ImaginaryNumber)B.values[Index]);
                        cn += (dynamic)A.values[Index]! * (dynamic)B.values[Index]!;
                        return imaginaryDotProduct(A, B, Index+1, cn);
                    case(ImaginaryNumbers.ComplexNumber, ImaginaryNumbers.ComplexNumber):
                        //cn += A.complexMultiplication((ImaginaryNumbers.ComplexNumber)A.values[Index], (ImaginaryNumbers.ComplexNumber)B.values[Index]);
                        cn += (dynamic)A.values[Index]! * (dynamic)B.values[Index]!;
                        return imaginaryDotProduct(A, B, Index+1, cn);
                    case(double, ImaginaryNumbers.ComplexNumber):
                    case(long, ImaginaryNumbers.ComplexNumber):
                    case(int, ImaginaryNumbers.ComplexNumber):
                    case(short, ImaginaryNumbers.ComplexNumber):
                    case(float, ImaginaryNumbers.ComplexNumber):
                        //cn += A.doubleComplexMultiplication((double)A.values[Index], (ImaginaryNumbers.ComplexNumber)B.values[Index]);
                        cn += Convert.ToDouble(A.values[Index]) * (dynamic)B.values[Index]!;
                        return imaginaryDotProduct(A, B, Index+1, cn);
                    case(ImaginaryNumbers.ComplexNumber, double):
                    case(ImaginaryNumbers.ComplexNumber, int):
                    case(ImaginaryNumbers.ComplexNumber, short):
                    case(ImaginaryNumbers.ComplexNumber, long):
                    case(ImaginaryNumbers.ComplexNumber, float):
                        //cn += A.doubleComplexMultiplication((double)A.values[Index], (ImaginaryNumbers.ComplexNumber)B.values[Index]);
                        cn += (dynamic)A.values[Index]! * Convert.ToDouble(B.values[Index]);
                        return imaginaryDotProduct(A, B, Index+1, cn);
                    case(ImaginaryNumbers.ImaginaryNumber, double):
                    case(ImaginaryNumbers.ImaginaryNumber, int):
                    case(ImaginaryNumbers.ImaginaryNumber, short):
                    case(ImaginaryNumbers.ImaginaryNumber, long):
                    case(ImaginaryNumbers.ImaginaryNumber, float):
                        Console.WriteLine(B.values[Index]!.ToString() + "!");
                        string? temp = B.values[Index]!.ToString();
                        double val = Double.Parse(temp!);
                        // if(A.values[Index] is ImaginaryNumbers.ImaginaryNumber)
                        // {
                        //     Console.WriteLine("YES!");
                        //     Console.WriteLine(val);
                        //     ImaginaryNumbers.ImaginaryNumber imag = A.values[Index];
                        //     var t = imag * val;
                        //     Console.WriteLine("VAL" + imag);
                        //     Console.Out.Flush();
                        // }
                        //  Console.WriteLine("HELLO: " + (ImaginaryNumbers.ImaginaryNumber)A.values[Index]);
                        // Console.WriteLine(B.values[Index]);
                        //ImaginaryNumbers.ImaginaryNumber test = new ImaginaryNumbers.ImaginaryNumber(A.values[Index]);
                        //ImaginaryNumbers.ImaginaryNumber im = A.values[Index] * val;
                        
                        //Console.WriteLine("TEMP: " + im);
                        cn += (dynamic)A.values[Index]! * val;
                        return imaginaryDotProduct(A, B, Index+1, cn);
                    case(double, ImaginaryNumbers.ImaginaryNumber):
                    case(int, ImaginaryNumbers.ImaginaryNumber):
                    case(float, ImaginaryNumbers.ImaginaryNumber):
                    case(long, ImaginaryNumbers.ImaginaryNumber):
                    case(short, ImaginaryNumbers.ImaginaryNumber):
                        cn += Convert.ToDouble(A.values[Index]) * (dynamic)B.values[Index]!;
                        return imaginaryDotProduct(A, B, Index+1, cn);
                    default:
                        cn += Convert.ToDouble(A.values[Index]) + Convert.ToDouble(B.values[Index]);
                        return imaginaryDotProduct(A, B, Index+1, cn);

                };
            }
        } 
        

        public static double DotProduct(Vector<T> A, Vector<T> B, int Index, double dp) {
            if(A.values.Length != B.values.Length) {
                throw new ArithmeticException("Dot-Products require Vectors of the same size.");
            }
            else if(A.values.OfType<ImaginaryNumbers.ImaginaryNumber>().Any() || B.values.OfType<ImaginaryNumbers.ImaginaryNumber>().Any()) {
                throw new ArithmeticException("Imaginary and Complex Numbers found. Use function 'imaginaryDotProduct'.");
            }
            else if(Index == A.values.Length-1) {
                dp += Convert.ToDouble(A.values[Index]) * Convert.ToDouble(B.values[Index]);
                Console.WriteLine(dp);
                return dp;
            }
            else
            {
                
                dp += Convert.ToDouble(A.values[Index]) * Convert.ToDouble(B.values[Index]);
                Console.WriteLine(dp);
                return DotProduct(A, B, Index+1, dp);
            }
        }

        

        public static void Scale(Vector<T> A, object s) {
            if(A.values.Length == 1) {
                 
            }
        }

        


    }
}