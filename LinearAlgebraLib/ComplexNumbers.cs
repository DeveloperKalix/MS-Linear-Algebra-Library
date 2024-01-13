// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using System.Dynamic;

using System.Reflection.Metadata.Ecma335;

namespace LinearAlgebraLibrary {
        public class ImaginaryNumbers {
        
        

        private static Dictionary<int, object> imaginaryPowers = new Dictionary<int, object>();
            public static void ImaginaryPowers() {
                imaginaryPowers.Add(0, 1);
                imaginaryPowers.Add(1, "i");
                imaginaryPowers.Add(2, -1);
                imaginaryPowers.Add(3, "-i");
                
            }

        
        
        public struct ImaginaryNumber {
            
            
            
            
            public double imaginaryNumber {get; set; }
            public int iPower {get; set;}

            public object iValue {get; set;}
            
            public ImaginaryNumber (double constant) {
                imaginaryNumber = constant;
                iPower = 1;
                iValue = 'i';
            }

            public override string ToString()
            {
                if(imaginaryNumber == 0) {
                    return $"0";
                }
                else
                {
                    switch(iValue) {
                    // case(1):
                    //     return $"{imaginaryNumber}";
                    // case(-1):
                    //     return $"{-imaginaryNumber}";
                    // case("-i"):
                    //     return $"{-imaginaryNumber}i";
                    default:
                        return $"{imaginaryNumber}{iValue}";
                    }
                }
                
            }

            public static ImaginaryNumber squareRoot(int negativeNumber) {
                if(negativeNumber < 0) {
                    int positiveNumber = Math.Abs(negativeNumber);
                    return new ImaginaryNumber(Math.Sqrt(positiveNumber));
                }
                else
                {
                    throw new ArithmeticException("This number cannot be converted into an imaginary number.");
                }
            }

            public static ImaginaryNumber squareRoot(double negativeNumber) {
                if(negativeNumber < 0) {
                        double positiveNumber = Math.Abs(negativeNumber);
                        return new ImaginaryNumber(Math.Sqrt(positiveNumber));
                }
                else
                {
                    throw new ArithmeticException("This number cannot be converted into an imaginary number.");
                }
            }

            public static ImaginaryNumber squareRoot(long negativeNumber) {
                if(negativeNumber < 0) {
                        long positiveNumber = Math.Abs(negativeNumber);
                        return new ImaginaryNumber(Math.Sqrt(positiveNumber));
                }
                else
                {
                    throw new ArithmeticException("This number cannot be converted into an imaginary number.");
                }
            }


            // Arithmetic Operations of Imaginary Numbers.
            public static ImaginaryNumber operator +(ImaginaryNumber a, ImaginaryNumber b) {
                return new ImaginaryNumber(a.imaginaryNumber + b.imaginaryNumber);
            }
            public static ImaginaryNumber operator -(ImaginaryNumber a, ImaginaryNumber b) {
                return new ImaginaryNumber(a.imaginaryNumber - b.imaginaryNumber);
            }
            public static ImaginaryNumber operator *(ImaginaryNumber a, ImaginaryNumber b) {
                ImaginaryNumber im = new ImaginaryNumber(a.imaginaryNumber*b.imaginaryNumber);
                im.iPower = a.iPower + b.iPower;
                im.iValue = imaginaryPowers[im.iPower % 4];
                return im;
            }
            public static ImaginaryNumber operator /(ImaginaryNumber a, ImaginaryNumber b) {
                ImaginaryNumber im = new ImaginaryNumber(a.imaginaryNumber/b.imaginaryNumber);
                im.iPower = a.iPower - b.iPower;
                im.iValue = imaginaryPowers[Math.Abs(im.iPower) % 4];
                return im;
            }
            public static ImaginaryNumber operator /(ImaginaryNumber n, int scalar) {
                ImaginaryNumber im = new ImaginaryNumber(n.imaginaryNumber/scalar);
                im.iPower = n.iPower;
                im.iValue = imaginaryPowers[Math.Abs(im.iPower) % 4];
                return im;
            }

            public static ImaginaryNumber operator /(int scalar, ImaginaryNumber n) {
                ImaginaryNumber im = new ImaginaryNumber(scalar/n.imaginaryNumber);
                im.iPower = n.iPower;
                im.iValue = imaginaryPowers[Math.Abs(im.iPower) % 4];
                return im;
            }

            public static ImaginaryNumber operator /(ImaginaryNumber n, double scalar) {
                ImaginaryNumber im = new ImaginaryNumber(n.imaginaryNumber/scalar);
                im.iPower = n.iPower;
                im.iValue = imaginaryPowers[Math.Abs(im.iPower) % 4];
                return im;
            }

            public static ImaginaryNumber operator /(double scalar, ImaginaryNumber n) {
                ImaginaryNumber im = new ImaginaryNumber(scalar/n.imaginaryNumber);
                im.iPower = n.iPower;
                im.iValue = imaginaryPowers[Math.Abs(im.iPower) % 4];
                return im;
            }

            public static ImaginaryNumber operator /(ImaginaryNumber n, float scalar) {
                ImaginaryNumber im = new ImaginaryNumber(n.imaginaryNumber/scalar);
                im.iPower = n.iPower;
                im.iValue = imaginaryPowers[Math.Abs(im.iPower) % 4];
                return im;
            }

            public static ImaginaryNumber operator /(float scalar, ImaginaryNumber n) {
                ImaginaryNumber im = new ImaginaryNumber(scalar/n.imaginaryNumber);
                im.iPower = n.iPower;
                im.iValue = imaginaryPowers[Math.Abs(im.iPower) % 4];
                return im;
            }

            public static ImaginaryNumber operator /(ImaginaryNumber n, long scalar) {
                ImaginaryNumber im = new ImaginaryNumber(n.imaginaryNumber/scalar);
                im.iPower = n.iPower;
                im.iValue = imaginaryPowers[Math.Abs(im.iPower) % 4];
                return im;
            }

            public static ImaginaryNumber operator /(long scalar, ImaginaryNumber n) {
                ImaginaryNumber im = new ImaginaryNumber(scalar/n.imaginaryNumber);
                im.iPower = n.iPower;
                im.iValue = imaginaryPowers[Math.Abs(im.iPower) % 4];
                return im;
            }

            public static ImaginaryNumber operator /(ImaginaryNumber n, short scalar) {
                ImaginaryNumber im = new ImaginaryNumber(n.imaginaryNumber/scalar);
                im.iPower = n.iPower;
                im.iValue = imaginaryPowers[Math.Abs(im.iPower) % 4];
                return im;
            }

            public static ImaginaryNumber operator /(short scalar, ImaginaryNumber n) {
                ImaginaryNumber im = new ImaginaryNumber(scalar/n.imaginaryNumber);
                im.iPower = n.iPower;
                im.iValue = imaginaryPowers[Math.Abs(im.iPower) % 4];
                return im;
            }

            public static ImaginaryNumber operator *(ImaginaryNumber n, int scalar) {
                ImaginaryNumber im = new ImaginaryNumber(n.imaginaryNumber*scalar);
                im.iPower = n.iPower;
                im.iValue = imaginaryPowers[Math.Abs(im.iPower) % 4];
                return im;
            }

            public static ImaginaryNumber operator *(int scalar, ImaginaryNumber n) {
                ImaginaryNumber im = new ImaginaryNumber(scalar*n.imaginaryNumber);
                im.iPower = n.iPower;
                im.iValue = imaginaryPowers[Math.Abs(im.iPower) % 4];
                return im;
            }

            public static ImaginaryNumber operator *(ImaginaryNumber n, double scalar) {
                ImaginaryNumber im = new ImaginaryNumber(n.imaginaryNumber*scalar);
                im.iPower = n.iPower;         
                im.iValue = imaginaryPowers[Math.Abs(im.iPower) % 4];
                return im;
            }

            public static ImaginaryNumber operator *(double scalar, ImaginaryNumber n) {
                ImaginaryNumber im = new ImaginaryNumber(scalar*n.imaginaryNumber);
                im.iPower = n.iPower;
                im.iValue = imaginaryPowers[Math.Abs(im.iPower) % 4];
                return im;
            }

            public static ImaginaryNumber operator *(ImaginaryNumber n, float scalar) {
                ImaginaryNumber im = new ImaginaryNumber(n.imaginaryNumber*scalar);
                im.iPower = n.iPower;
                im.iValue = imaginaryPowers[Math.Abs(im.iPower) % 4];
                return im;
            }

            public static ImaginaryNumber operator *(float scalar, ImaginaryNumber n) {
                ImaginaryNumber im = new ImaginaryNumber(scalar*n.imaginaryNumber);
                im.iPower = n.iPower;
                im.iValue = imaginaryPowers[Math.Abs(im.iPower) % 4];
                return im;
            }

            public static ImaginaryNumber operator *(ImaginaryNumber n, long scalar) {
                ImaginaryNumber im = new ImaginaryNumber(n.imaginaryNumber*scalar);
                im.iPower = n.iPower;
                im.iValue = imaginaryPowers[Math.Abs(im.iPower) % 4];
                return im;
            }

            public static ImaginaryNumber operator *(long scalar, ImaginaryNumber n) {
                ImaginaryNumber im = new ImaginaryNumber(scalar*n.imaginaryNumber);
                im.iPower = n.iPower;
                im.iValue = imaginaryPowers[Math.Abs(im.iPower) % 4];
                return im;
            }

            public static ImaginaryNumber operator *(ImaginaryNumber n, short scalar) {
                ImaginaryNumber im = new ImaginaryNumber(n.imaginaryNumber*scalar);
                im.iPower = n.iPower;
                im.iValue = imaginaryPowers[Math.Abs(im.iPower) % 4];
                return im;
            }

            public static ImaginaryNumber operator *(short scalar, ImaginaryNumber n) {
                ImaginaryNumber im = new ImaginaryNumber(scalar*n.imaginaryNumber);
                im.iPower = n.iPower;
                im.iValue = imaginaryPowers[Math.Abs(im.iPower) % 4];
                return im;
            }

            public static ComplexNumber operator +(int constant, ImaginaryNumber n) {
                ComplexNumber cn = new ComplexNumber(constant, n.imaginaryNumber);
                cn.iPower = n.iPower;
                cn.iValue = imaginaryPowers[Math.Abs(n.iPower) % 4];
                return cn;
            }

            public static ComplexNumber operator +(double constant, ImaginaryNumber n) {
                ComplexNumber cn = new ComplexNumber(constant, n.imaginaryNumber);
                cn.iPower = n.iPower;
                cn.iValue = imaginaryPowers[Math.Abs(n.iPower) % 4];
                return cn;
            }

            public static ComplexNumber operator +(float constant, ImaginaryNumber n) {
                ComplexNumber cn = new ComplexNumber(constant, n.imaginaryNumber);
                cn.iPower = n.iPower;
                cn.iValue = imaginaryPowers[Math.Abs(n.iPower) % 4];
                return cn;
            }

            public static ComplexNumber operator +(long constant, ImaginaryNumber n) {
                ComplexNumber cn = new ComplexNumber(constant, n.imaginaryNumber);
                cn.iPower = n.iPower;
                cn.iValue = imaginaryPowers[Math.Abs(n.iPower) % 4];
                return cn;
            }

            public static ComplexNumber operator +(short constant, ImaginaryNumber n) {
                ComplexNumber cn = new ComplexNumber(constant, n.imaginaryNumber);
                cn.iPower = n.iPower;
                cn.iValue = imaginaryPowers[Math.Abs(n.iPower) % 4];
                return cn;
            }

            public static ComplexNumber operator +(ImaginaryNumber n, int constant) {
                ComplexNumber cn = new ComplexNumber(constant, n.imaginaryNumber);
                cn.iPower = n.iPower;
                cn.iValue = imaginaryPowers[Math.Abs(n.iPower) % 4];
                return cn;
            }

            public static ComplexNumber operator +(ImaginaryNumber n, double constant) {
                ComplexNumber cn = new ComplexNumber(constant, n.imaginaryNumber);
                cn.iPower = n.iPower;
                cn.iValue = imaginaryPowers[Math.Abs(n.iPower) % 4];
                return cn;
            }

            public static ComplexNumber operator +(ImaginaryNumber n, float constant) {
                ComplexNumber cn = new ComplexNumber(constant, n.imaginaryNumber);
                cn.iPower = n.iPower;
                cn.iValue = imaginaryPowers[Math.Abs(n.iPower) % 4];
                return cn;
            }

            public static ComplexNumber operator +(ImaginaryNumber n, short constant) {
                ComplexNumber cn = new ComplexNumber(constant, n.imaginaryNumber);
                cn.iPower = n.iPower;
                cn.iValue = imaginaryPowers[Math.Abs(n.iPower) % 4];
                return cn;
            }

            public static ComplexNumber operator +(ImaginaryNumber n, long constant) {
                ComplexNumber cn = new ComplexNumber(constant, n.imaginaryNumber);
                cn.iPower = n.iPower;
                cn.iValue = imaginaryPowers[Math.Abs(n.iPower) % 4];
                return cn;
            }

            public static ComplexNumber operator -(ImaginaryNumber n, int constant) {
                ComplexNumber cn = new ComplexNumber(-constant, n.imaginaryNumber);
                cn.iPower = n.iPower;
                cn.iValue = imaginaryPowers[Math.Abs(n.iPower) % 4];
                return cn;
            }

            public static ComplexNumber operator -(ImaginaryNumber n, double constant) {
                ComplexNumber cn = new ComplexNumber(-constant, n.imaginaryNumber);
                cn.iPower = n.iPower;
                cn.iValue = imaginaryPowers[Math.Abs(n.iPower) % 4];
                return cn;
            }

            public static ComplexNumber operator -(ImaginaryNumber n, float constant) {
                ComplexNumber cn = new ComplexNumber(-constant, n.imaginaryNumber);
                cn.iPower = n.iPower;
                cn.iValue = imaginaryPowers[Math.Abs(n.iPower) % 4];
                return cn;
            }

            public static ComplexNumber operator -(ImaginaryNumber n, short constant) {
                ComplexNumber cn = new ComplexNumber(-constant, n.imaginaryNumber);
                cn.iPower = n.iPower;
                cn.iValue = imaginaryPowers[Math.Abs(n.iPower) % 4];
                return cn;
            }

            public static ComplexNumber operator -(ImaginaryNumber n, long constant) {
                ComplexNumber cn = new ComplexNumber(-constant, n.imaginaryNumber);
                cn.iPower = n.iPower;
                cn.iValue = imaginaryPowers[Math.Abs(n.iPower) % 4];
                return cn;
            }

            public static ComplexNumber operator -(int constant, ImaginaryNumber n) {
                ComplexNumber cn = new ComplexNumber(constant, -n.imaginaryNumber);
                cn.iPower = n.iPower;
                cn.iValue = imaginaryPowers[Math.Abs(n.iPower) % 4];
                return cn;
            }

            public static ComplexNumber operator -(float constant, ImaginaryNumber n) {
                ComplexNumber cn = new ComplexNumber(constant, -n.imaginaryNumber);
                cn.iPower = n.iPower;
                cn.iValue = imaginaryPowers[Math.Abs(n.iPower) % 4];
                return cn;
            }

            public static ComplexNumber operator -(double constant, ImaginaryNumber n) {
                ComplexNumber cn = new ComplexNumber(constant, -n.imaginaryNumber);
                cn.iPower = n.iPower;
                cn.iValue = imaginaryPowers[Math.Abs(n.iPower) % 4];
                return cn;
            }

            public static ComplexNumber operator -(long constant, ImaginaryNumber n) {
                ComplexNumber cn = new ComplexNumber(constant, -n.imaginaryNumber);
                cn.iPower = n.iPower;
                cn.iValue = imaginaryPowers[Math.Abs(n.iPower) % 4];
                return cn;
            }

            public static ComplexNumber operator -(short constant, ImaginaryNumber n) {
                ComplexNumber cn = new ComplexNumber(constant, -n.imaginaryNumber);
                cn.iPower = n.iPower;
                cn.iValue = imaginaryPowers[Math.Abs(n.iPower) % 4];
                return cn;
            }

            
        }
        
        public struct ComplexNumber {
            public double Real { get; set; }
            public double Imaginary { get;  set; }
            public int iPower {get; set;}

            public object iValue {get; set;}
            public ComplexNumber(double realNumber, double imaginaryConstant) 
            {
                Real = realNumber;
                Imaginary = imaginaryConstant;
                iPower = 1;
                iValue = 'i';

            }

            public ComplexNumber(double realNumber, ImaginaryNumber imaginaryNumber) {
                Real = realNumber;
                Imaginary = imaginaryNumber.imaginaryNumber;
                iPower = 1;
                iValue = 'i';
            }

            public override string ToString()
            {
                if(Imaginary == 0) {
                    return $"{Real}";
                }
                else
                {
                    return $"{Real} + ({Imaginary}i)";
                }
                
            }

            public static ComplexNumber operator +(ComplexNumber a, ComplexNumber b) {
                return new ComplexNumber(a.Real + b.Real, a.Imaginary + b.Imaginary);
            }

            public static ComplexNumber operator +(ComplexNumber a, ImaginaryNumber b) {
                return new ComplexNumber(a.Real, a.Imaginary + b.imaginaryNumber);
            }

            public static ComplexNumber operator +(ImaginaryNumber a, ComplexNumber b) {
                return new ComplexNumber(b.Real, a.imaginaryNumber + b.Imaginary);
            }

            public static ComplexNumber operator +(int a, ComplexNumber b) {
                return new ComplexNumber(b.Real + a, b.Imaginary);
            }

            public static ComplexNumber operator +(short a, ComplexNumber b) {
                return new ComplexNumber(b.Real + a, b.Imaginary);
            }

            public static ComplexNumber operator +(long a, ComplexNumber b) {
                return new ComplexNumber(b.Real + a, b.Imaginary);
            }

            public static ComplexNumber operator +(float a, ComplexNumber b) {
                return new ComplexNumber(b.Real + a, b.Imaginary);
            }

            public static ComplexNumber operator +(double a, ComplexNumber b) {
                return new ComplexNumber(b.Real + a, b.Imaginary);
            }

            public static ComplexNumber operator +(ComplexNumber a, int b) {
                return new ComplexNumber(a.Real + b, a.Imaginary);
            }

            public static ComplexNumber operator +(ComplexNumber a, short b) {
                return new ComplexNumber(a.Real + b, a.Imaginary);
            }

            public static ComplexNumber operator +(ComplexNumber a, long b) {
                return new ComplexNumber(a.Real + b, a.Imaginary);
            }

            public static ComplexNumber operator +(ComplexNumber a, float b) {
                return new ComplexNumber(a.Real + b, a.Imaginary);
            }

            public static ComplexNumber operator +(ComplexNumber a, double b) {
                return new ComplexNumber(a.Real + b, a.Imaginary);
            }
            
            public static ComplexNumber operator -(ComplexNumber a, ComplexNumber b) {
                return new ComplexNumber(a.Real - b.Real, a.Imaginary - b.Imaginary);
            }

            public static ComplexNumber operator -(ComplexNumber a, ImaginaryNumber b) {
                return new ComplexNumber(a.Real, a.Imaginary - b.imaginaryNumber);
            }

            public static ComplexNumber operator -(ImaginaryNumber a, ComplexNumber b) {
                return new ComplexNumber(-b.Real, a.imaginaryNumber - b.Imaginary);
            }

            public static ComplexNumber operator -(int a, ComplexNumber b) {
                return new ComplexNumber(a-b.Real, b.Imaginary);
            }
            public static ComplexNumber operator -(short a, ComplexNumber b) {
                return new ComplexNumber(a-b.Real, b.Imaginary);
            }
            public static ComplexNumber operator -(long a, ComplexNumber b) {
                return new ComplexNumber(a-b.Real, b.Imaginary);
            }
            public static ComplexNumber operator -(float a, ComplexNumber b) {
                return new ComplexNumber(a-b.Real, b.Imaginary);
            }
            public static ComplexNumber operator -(double a, ComplexNumber b) {
                return new ComplexNumber(a-b.Real, b.Imaginary);
            }
            public static ComplexNumber operator -(ComplexNumber a, int b) {
                return new ComplexNumber(a.Real-b, a.Imaginary);
            }
            public static ComplexNumber operator -(ComplexNumber a, short b) {
                return new ComplexNumber(a.Real-b, a.Imaginary);
            }
            public static ComplexNumber operator -(ComplexNumber a, long b) {
                return new ComplexNumber(a.Real-b, a.Imaginary);
            }
            public static ComplexNumber operator -(ComplexNumber a, float b) {
                return new ComplexNumber(a.Real-b, a.Imaginary);
            }
            public static ComplexNumber operator -(ComplexNumber a, double b) {
                return new ComplexNumber(a.Real-b, a.Imaginary);
            }
            public static ComplexNumber operator *(ImaginaryNumber a, ComplexNumber b) {
                
                ComplexNumber cn = new ComplexNumber(-(b.Imaginary*a.imaginaryNumber), b.Real*a.imaginaryNumber);
                cn.iValue = b.iValue;
                cn.iPower = b.iPower;
                return cn;
            }

            public static ComplexNumber operator *(int a, ComplexNumber b) {
                
                ComplexNumber cn = new ComplexNumber(b.Real*a, b.Imaginary*a);
                cn.iValue = b.iValue;
                cn.iPower = b.iPower;
                return cn;
            }
            public static ComplexNumber operator *(float a, ComplexNumber b) {
                
                ComplexNumber cn = new ComplexNumber(b.Real*a, b.Imaginary*a);
                cn.iValue = b.iValue;
                cn.iPower = b.iPower;
                return cn;
            }
            public static ComplexNumber operator *(double a, ComplexNumber b) {
                
                ComplexNumber cn = new ComplexNumber(b.Real*a, b.Imaginary*a);
                cn.iValue = b.iValue;
                cn.iPower = b.iPower;
                return cn;
            }
            public static ComplexNumber operator *(short a, ComplexNumber b) {
                
                ComplexNumber cn = new ComplexNumber(b.Real*a, b.Imaginary*a);
                cn.iValue = b.iValue;
                cn.iPower = b.iPower;
                return cn;
            }
            public static ComplexNumber operator *(long a, ComplexNumber b) {
                
                ComplexNumber cn = new ComplexNumber(b.Real*a, b.Imaginary*a);
                cn.iValue = b.iValue;
                cn.iPower = b.iPower;
                return cn;
            }

            public static ComplexNumber operator *(ComplexNumber a, int b) {
                
                ComplexNumber cn = new ComplexNumber(a.Real*b, a.Imaginary*b);
                cn.iValue = a.iValue;
                cn.iPower = a.iPower;
                return cn;
            }
            public static ComplexNumber operator *(ComplexNumber a, double b) {
                
                ComplexNumber cn = new ComplexNumber(a.Real*b, a.Imaginary*b);
                cn.iValue = a.iValue;
                cn.iPower = a.iPower;
                return cn;
            }
            public static ComplexNumber operator *(ComplexNumber a, short b) {
                
                ComplexNumber cn = new ComplexNumber(a.Real*b, a.Imaginary*b);
                cn.iValue = a.iValue;
                cn.iPower = a.iPower;
                return cn;
            }
            public static ComplexNumber operator *(ComplexNumber a, long b) {
                
                ComplexNumber cn = new ComplexNumber(a.Real*b, a.Imaginary*b);
                cn.iValue = a.iValue;
                cn.iPower = a.iPower;
                return cn;
            }
            public static ComplexNumber operator *(ComplexNumber a, float b) {
                
                ComplexNumber cn = new ComplexNumber(a.Real*b, a.Imaginary*b);
                cn.iValue = a.iValue;
                cn.iPower = a.iPower;
                return cn;
            }
            public static ComplexNumber operator *(ComplexNumber b, ImaginaryNumber a) {
                
                ComplexNumber cn = new ComplexNumber(-(b.Imaginary*a.imaginaryNumber), b.Real*a.imaginaryNumber);
                cn.iValue = b.iValue;
                cn.iPower = b.iPower;
                return cn;
            }
            public static ComplexNumber operator /(ComplexNumber b, ImaginaryNumber a) {
                
                ComplexNumber cn = new ComplexNumber(-(b.Imaginary*a.imaginaryNumber), b.Real*a.imaginaryNumber);
                cn.iValue = b.iValue;
                cn.iPower = b.iPower;
                return cn;
            }
            public static ComplexNumber operator /(ComplexNumber b, int a) {
                
                ComplexNumber cn = new ComplexNumber(b.Real/a, b.Imaginary/a);
                cn.iValue = b.iValue;
                cn.iPower = b.iPower;
                return cn;
            }
            public static ComplexNumber operator /(ComplexNumber b, long a) {
                
                ComplexNumber cn = new ComplexNumber(b.Real/a, b.Imaginary/a);
                cn.iValue = b.iValue;
                cn.iPower = b.iPower;
                return cn;
            }
            public static ComplexNumber operator /(ComplexNumber b, short a) {
                
                ComplexNumber cn = new ComplexNumber(b.Real/a, b.Imaginary/a);
                cn.iValue = b.iValue;
                cn.iPower = b.iPower;
                return cn;
            }
            public static ComplexNumber operator /(ComplexNumber b, float a) {
                
                ComplexNumber cn = new ComplexNumber(b.Real/a, b.Imaginary/a);
                cn.iValue = b.iValue;
                cn.iPower = b.iPower;
                return cn;
            }
            public static ComplexNumber operator /(ComplexNumber b, double a) {
                
                ComplexNumber cn = new ComplexNumber(b.Real/a, b.Imaginary/a);
                cn.iValue = b.iValue;
                cn.iPower = b.iPower;
                return cn;
            }
            public static ComplexNumber operator /(int a, ComplexNumber b) {
                
                ComplexNumber cn = new ComplexNumber(b.Real/a, b.Imaginary/a);
                cn.iValue = b.iValue;
                cn.iPower = b.iPower;
                return cn;
            }
            public static ComplexNumber operator /(long a, ComplexNumber b) {
                
                ComplexNumber cn = new ComplexNumber(b.Real/a, b.Imaginary/a);
                cn.iValue = b.iValue;
                cn.iPower = b.iPower;
                return cn;
            }
            public static ComplexNumber operator /(short a, ComplexNumber b) {
                
                ComplexNumber cn = new ComplexNumber(b.Real/a, b.Imaginary/a);
                cn.iValue = b.iValue;
                cn.iPower = b.iPower;
                return cn;
            }
            public static ComplexNumber operator /(float a, ComplexNumber b) {
                
                ComplexNumber cn = new ComplexNumber(b.Real/a, b.Imaginary/a);
                cn.iValue = b.iValue;
                cn.iPower = b.iPower;
                return cn;
            }
            public static ComplexNumber operator /(double a, ComplexNumber b) {
                
                ComplexNumber cn = new ComplexNumber(b.Real/a, b.Imaginary/a);
                cn.iValue = b.iValue;
                cn.iPower = b.iPower;
                return cn;
            }
            public static ComplexNumber operator /(ImaginaryNumber a, ComplexNumber b) {
                
                ComplexNumber cn = new ComplexNumber(-(b.Imaginary*a.imaginaryNumber), b.Real*a.imaginaryNumber);
                cn.iValue = b.iValue;
                cn.iPower = b.iPower;
                return cn;
            }

            public static ComplexNumber operator *(ComplexNumber a, ComplexNumber b) {
                ComplexNumber cn = new ComplexNumber((a.Real*b.Real-a.Imaginary*b.Imaginary),(a.Real*b.Imaginary + a.Imaginary*b.Real));
                cn.iValue = b.iValue;
                cn.iPower = b.iPower;
                return cn;
            }

            public static ComplexNumber operator /(ComplexNumber a, ComplexNumber b) {
                ComplexNumber cn = new ComplexNumber(((a.Real*b.Real)+(a.Imaginary*b.Imaginary))/(b.Real*b.Real + b.Imaginary*b.Imaginary),(a.Imaginary*b.Real - a.Real*b.Imaginary)/(b.Real*b.Real + b.Imaginary*b.Imaginary));
                cn.iValue = b.iValue;
                cn.iPower = b.iPower;
                return cn;
            }
            

        }

        public static ImaginaryNumber Conjugate(ImaginaryNumber b) {
            b.imaginaryNumber = -1 * b.imaginaryNumber;
            return b;
        }
        public static ComplexNumber Conjugate(ComplexNumber Z) {
            Z.Imaginary = -1 * (Z.Imaginary);
            return Z;
        }

        

        public static void Main(string[] args) {
            ImaginaryNumber inum = new ImaginaryNumber(-5);
            ImaginaryNumber inum2 = new ImaginaryNumber(-2);
            // inum2.iPower = 2;
            ComplexNumber cnum = new ComplexNumber(5, 3);
            ComplexNumber cnum2 = new ComplexNumber(2.5, 0.5);

            ComplexNumber cnum4 = new ComplexNumber(4, -2);
            ComplexNumber cnum5 = new ComplexNumber(2, 1);


            inum2 = ImaginaryNumbers.Conjugate(inum2);
            cnum = ImaginaryNumbers.Conjugate(cnum);

            ImaginaryNumber inumt = ImaginaryNumber.squareRoot(-8.5655);
            //Console.WriteLine(inumt);
            ComplexNumber cnum3 = cnum * cnum2;
            //Console.WriteLine(inum2);
            //Console.WriteLine(cnum3);
            cnum3 = cnum4 / cnum5;
            //Console.WriteLine(cnum3);
            object[] test =  [new ImaginaryNumber(3), 5, 7, 8, new ImaginaryNumber(3), 2];
            object[] test2 =  [15, 2, 3, new ImaginaryNumber(2), 1, 9];

            Vector<object> vec = new Vector<object>(test);
            Vector<object> vec2 = new Vector<object>(test2);
            //double num = 0;
            // Console.WriteLine(vec.values[0].GetType());
            // Console.WriteLine(vec.values[1].GetType());
            // Console.Write(cnum5.iPower);
            // Console.WriteLine(cnum5.iValue);
            // foreach(var item in test) {
            //     Console.WriteLine(item);
            // }
            
            cnum5 = Vector<object>.imaginaryDotProduct(vec, vec2, 0, cnum5);
            
            Console.WriteLine(cnum5);
            

        }
        
    }

}

