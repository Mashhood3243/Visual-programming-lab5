using System.Text;
using System.Threading.Tasks;

// TASK 1
namespace lab5_1
{
    public enum Department
    {
        ComputerScience,
        ElectricalEngineering,
        MechanicalEngineering
    }

    public class Person
    {
        private string name;

        public Person()
        {
            name = null;
        }

        public Person(string name)
        {
            this.name = name;
        }

        public string Name
        {
            get
            {
                return name;
            }
            set { name = value; }
        }
    }

    public class Student : Person
    {
        private
     string regNo;
        private int age;
        private Department program;

        public Student() : base()
        {
            regNo = null;
            age = 0;
            program = Department.ComputerScience;
         
        }

        public Student(string name, string regNo, int age, Department program) : base(name)
        {
            this.regNo = regNo;
            this.age = age;
            this.program = program;
        }

        public string RegNo
        {
            get { return regNo; }
            set { regNo = value; }
        }

        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        public Department Program
        {
            get { return program; }
            set
            {
                program = value;
            }
        }
    }
    public class Program
    {
        public static void Main()
        {
           
            Person person = new Person("Ahmed");
            Console.WriteLine("Person's name: " + person.Name);

       
            Student student = new Student("Saboor", "233807", 20, Department.ComputerScience);
            Console.WriteLine("Student's name: " + student.Name);
            Console.WriteLine("Student's registration number: " + student.RegNo);
            Console.WriteLine("Student's age: " + student.Age);
            Console.WriteLine("Student's program: " + student.Program);
        }
    }



}
//namespace Lab5_2
//{


//    //exercise #2
//    public class Customer
//    {
//        public int CustomerId { get; set; }
//        public string LastName { get; set; }
//        public string FirstName { get; set; }
//    }

//    public
//     class RetailCustomer : Customer
//    {
//        public string CreditCardType { get; set; }
//        public string CreditCardNo { get; set; }
//    }

//    public class CorporateCustomer : Customer
//    {
//        public string CompanyName { get; set; }
//        public int FrequentFlyerPts { get; set; }
//        public string BillingAccountNo { get; set; }
//    }

//    public class Reservation
//    {
//        public int ReservationNo { get; set; }
//        public DateTime Date { get; set; }
//        public Customer Customer { get; set; }
//    }

//    public class Seat
//    {
//        public int RowNo { get; set; }
//        public int SeatNo { get; set; }
//        public decimal Price { get; set; }
//        public string Status { get; set; }
//        public Reservation Reservation { get; set; }
//        public Flight Flight { get; set; }
//    }

//    public class Flight
//    {
//        public int FlightId { get; set; }
//        public DateTime Date { get; set; }
//        public string Origin { get; set; }
//        public string Destination { get; set; }
//        public DateTime DepartureTime { get; set; }
//        public DateTime ArrivalTime { get; set; }
//        public int SeatingCapacity { get; set; }
//        public List<Seat> Seats
//        {
//            get;
//            set;
//        }
//    }

//    public class Program
//    {
//        public static void Main()
//        {

//            RetailCustomer retailCustomer = new RetailCustomer
//            {
//                CustomerId = 1,
//                LastName = "Furqan",
//                FirstName = "Ali",
//                CreditCardType = "Visa",
//                CreditCardNo = "1234567890123456"
//            };

//            Flight flight = new Flight
//            {
//                FlightId = 1,
//                Date = DateTime.Now,
//                Origin = "Multan",
//                Destination = "Lahore",
//                DepartureTime = DateTime.Now,
//                ArrivalTime = DateTime.Now.AddHours(5),
//                SeatingCapacity = 100
//            };

//            Reservation reservation = new Reservation
//            {
//                ReservationNo = 1,
//                Date = DateTime.Now,
//                Customer = retailCustomer
//            };

//            Seat seat = new Seat
//            {
//                RowNo = 1,
//                SeatNo = 1,
//                Price = 100.00m,
//                Status = "Available",
//                Reservation = reservation,
//                Flight = flight
//            };

//            // Add the seat to the flight
//            flight.Seats = new List<Seat>();
//            flight.Seats.Add(seat);

//            // Print some information
//            Console.WriteLine("Customer: " + retailCustomer.FirstName + " " + retailCustomer.LastName);
//            Console.WriteLine("Flight: " + flight.Origin + " to " + flight.Destination);
//            Console.WriteLine("Reservation: " + reservation.ReservationNo);
//            Console.WriteLine("Seat: " + seat.RowNo + " " + seat.SeatNo);
//        }
//    }




//}