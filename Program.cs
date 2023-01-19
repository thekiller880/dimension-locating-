ng System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoloLearn
{
	class Program
	{
		static void Main(string[] args)
		{
			
		}
	}
}
using System;

class Program
{
    static void Main(string[] args)
    {
        // Define the constants
        const double pi = 3.14159265;
        const double c = 299792458;
        const double G = 6.67408e-11;
        double universe_size = 93e9; // in meters
        // Define the variables
        double x, y, z;
        double r, theta, phi;
        double t, v;

        // Get the coordinates
        Console.WriteLine("Enter the x coordinate: ");
        x = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter the y coordinate: ");
        y = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter the z coordinate: ");
        z = double.Parse(Console.ReadLine());

        // Convert to spherical coordinates
        r = Math.Sqrt(x*x + y*y + z*z);
        theta = Math.Acos(z/r);
        phi = Math.Atan2(y, x);

        // Calculate the time and velocity
        t = r/c;
        v = Math.Sqrt(G*r);

        // Output the results
        Console.WriteLine("r = " + r);
        Console.WriteLine("theta = " + theta);
        Console.WriteLine("phi = " + phi);
        Console.WriteLine("t = " + t);
        Console.WriteLine("v = " + v);
        Console.WriteLine("Universe Size = " + universe_size + " meters");
    }
}
