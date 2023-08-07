using System.Net.Http.Headers;
using System.Runtime.Intrinsics.X86;
using System.Security.Cryptography.X509Certificates;
using System.Threading;

namespace CLass_of_Poject
{
    class ShowRoom
    {
        class Address
        {
            public int House_No, Pincode;
            public string Street_Address, Near_Location, City;

            public Address(int House_No, string Street_Address, string Near_Location, string City, int Pincode)
            {
                this.House_No = House_No;
                this.Street_Address = Street_Address;
                this.Near_Location = Near_Location;
                this.City = City;
                this.Pincode = Pincode;
            }
        }

        class Customer
        {
            public string Customer_ID;
            public string Customer_First_Name;
            public string Customer_Last_Name;
            public string Customer_Email;
            public double Customer_Phone;
            public Address address;
            public Customer(string Customer_ID, string Customer_First_Name, string Customer_Last_Name, string Customer_Email, double Customer_Phone, Address address)
            {
                this.Customer_ID = Customer_ID;
                this.Customer_First_Name = Customer_First_Name;
                this.Customer_Last_Name = Customer_Last_Name;
                this.Customer_Email = Customer_Email;
                this.Customer_Phone = Customer_Phone;
                this.address = address;
            }
            public void CustomerDetails()
            {
                Console.WriteLine(" \n \nCustomer ID = " + Customer_ID);
                Console.WriteLine("\nCustomer First Name = " + Customer_First_Name);
                Console.WriteLine("\nCustomer Last Name = " + Customer_Last_Name);
                Console.WriteLine("\nCustomer Phone Number = " + Customer_Phone);
                Console.WriteLine("\nCustomer Email ID = " + Customer_Email);
                Console.WriteLine("\nCustomer Address = Houe NO. " + address.House_No + " " + address.Street_Address + " " + address.Near_Location + " " + address.City + " " + address.Pincode);
            }
        }
        class Vehicle
        {
            public string Model_Number;
            public string Model_Name;
            public int Model_Price;
            public string Date;


            public Vehicle(string Model_Number, string Model_Name, int Model_Price, string Date)
            {
                this.Model_Number = Model_Number;
                this.Model_Name = Model_Name;
                this.Model_Price = Model_Price;
                this.Date = Date;
            }

            public void VechicelDetails()
            {
                Console.WriteLine("\nVehicle Model Number =  " + Model_Number);
                Console.WriteLine("\nVehicle Model Name = " + Model_Name);
                Console.WriteLine("\nVehicle Price = " + Model_Price);
                Console.WriteLine("\nVehicle Purchaces Date = " + Date);
            }
        }

        class VehicleAccesseries : Vehicle
        {
            public int Auxiliary_Light;
            public int Bash_Plate;
            public int Carriers;
            public int Crash_Guard;
            public int Windshield;
            public int Headlight_Grill;
            public int Leverguards;
            public int Total_Price;

            public VehicleAccesseries(int Auxiliary_Light, int Bash_Plate, int Carriers, int Crash_Guard, int Windshield, int Headlight_Grill, int Leverguards, int Total_Price, string Model_Number, string Model_Name, int Model_Price, string Date) : base(Model_Number, Model_Name, Model_Price, Date)
            {
                this.Auxiliary_Light = Auxiliary_Light;
                this.Bash_Plate = Bash_Plate;
                this.Carriers = Carriers;
                this.Crash_Guard = Crash_Guard;
                this.Windshield = Windshield;
                this.Headlight_Grill = Headlight_Grill;
                this.Leverguards = Leverguards;
                this.Total_Price = Total_Price;


            }

            public void AccesseriesDitails()
            {
                Console.WriteLine("\nVehicle Auxiliary Light = " + Auxiliary_Light);
                Console.WriteLine("\nVehicle Bash Plate =  " + Bash_Plate);
                Console.WriteLine("\nVehicle Carrier = " + Carriers);
                Console.WriteLine("\nVehicle Crash Guard =  " + Crash_Guard);
                Console.WriteLine("\nVehicle WindShield = " + Windshield);
                Console.WriteLine("\nVehicle HeadLight Grill =  " + Headlight_Grill);
                Console.WriteLine("\nVehicle Leverguard =  " + Leverguards);
                Console.WriteLine("\nTotal Vehicle Accesseries Price that Customer Buy  =  " + Total_Price);

            }
        }

        class Cash_Billing
        {

            public string Cash_Mode;
            public double Transaction_ID;
            public double Amount_Pay;
            public Cash_Billing(string Cash_Mode, double Transaction_ID, double amount_Pay)
            {
                this.Cash_Mode = Cash_Mode;
                this.Transaction_ID = Transaction_ID;
                this.Amount_Pay = amount_Pay;
            }

            public void CashBillingDetails()
            {
                Console.WriteLine("\nThe Mode Of Cash Payment = " + Cash_Mode);
                Console.WriteLine("\nThe Cash Payment Transaction ID = " + Transaction_ID);
                Console.WriteLine("\nTotal Cash Amount Customer Pay = " + Amount_Pay);
            }
        }

        class Bank
        {
            public string Bank_Name;
            private double Customer_Bank_Account_Number;
            public string Customer_Bank_IFCS_CODE;


            public Bank(string Bank_Name, double Customer_Bank_Account_Number, string Customer_Bank_IFCS_CODE)
            {
                this.Bank_Name = Bank_Name;
                this.Customer_Bank_Account_Number = Customer_Bank_Account_Number;
                this.Customer_Bank_IFCS_CODE = Customer_Bank_IFCS_CODE;

            }
            public void BankDetails()
            {
                Console.WriteLine("\nThe Bank Name = " + Bank_Name);
                Console.WriteLine("\nBank Account Number = " + Customer_Bank_Account_Number);
                Console.WriteLine("\nBank IFCS Code = " + Customer_Bank_IFCS_CODE);
            }
        }
        
        class LoanBilling : VehicleAccesseries
        {

            public double Interest_Rate;
            public int Loan_Tenure;
            public double Loan_EMI;
            public double Total_vehicle_Loan_Price;

            public LoanBilling(double Interest_Rate, int Loan_Tenure, double Loan_EMI, double Total_vehicle_Loan_Price, int Auxiliary_Light, int Bash_Plate, int Carriers, int Crash_Guard, int Windshield, int Headlight_Grill, int Leverguards, int Total_Price, string Model_Number, string Model_Name, int Model_Price, string Date) : base(Auxiliary_Light, Bash_Plate, Carriers, Crash_Guard, Windshield, Headlight_Grill, Leverguards, Total_Price, Model_Number, Model_Name, Model_Price, Date)

            {
                this.Interest_Rate = Interest_Rate;
                this.Loan_Tenure = Loan_Tenure;
                this.Loan_EMI = Loan_EMI;
                this.Total_vehicle_Loan_Price = Total_vehicle_Loan_Price;

            }
            public void LoanDetails()
            {
                Console.WriteLine("\nLoan Interest Rate = " + Interest_Rate);
                Console.WriteLine("\nLoan Tenure = " + Loan_Tenure);
                Console.WriteLine("\nMonthly EMI to Pay = " + Loan_EMI);
                Console.WriteLine("\nTotal Loan Amount to Pay = " + (Total_vehicle_Loan_Price + Total_Price));
            }


        }

        static void Main(string[] args)
        {
            string x, y, z, j;
            double i;

            string b, c, d;
            int house_pin, e;

            string ModelNumber, ModelName, Purchas_date;
            int VechPrice;

            int Auxiliary_Light, Bash_Plate, Carriers, Crash_Guard, Windshield, Headlight_Grill, Leverguards;
            int Total_Price;

            string mode_cash;
            double trancatoin, amount;

            string Bank_Name, Bank_Code;
            double Bank_Account;

            int year;
            double inrate, emi, loan_price;

            int VechPrice_addAccess_Price;


            Console.WriteLine("Enter The Customer ID");
            x = Console.ReadLine();

            Console.WriteLine("\nEnter The Customer First Name");
            y = Console.ReadLine();

            Console.WriteLine("\nEnter The Customer Last Name");
            z = Console.ReadLine();

            Console.WriteLine("\nEnter The Customer Phone Name");
            i = double.Parse(Console.ReadLine());

            Console.WriteLine("\nEnter The Customer Email ID");
            j = Console.ReadLine();

            Console.WriteLine("\nEnter Customer Address House No");
            house_pin = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nEnter Street Address");
            b = Console.ReadLine();

            Console.WriteLine("\nEnter Land Marks");
            c = Console.ReadLine();

            Console.WriteLine("\nEnter City Name");
            d = Console.ReadLine();

            Console.WriteLine("\nEnter Area Pincode");
            e = Convert.ToInt32(Console.ReadLine());



            Console.WriteLine("\nEnter Vehicle Purchasce Date");
            Purchas_date = Console.ReadLine();

            Console.WriteLine("\nEnter Vehicle Model Number ");
            ModelNumber = Console.ReadLine();

            Console.WriteLine("\nEnter Vechicle Model Name ");
            ModelName = Console.ReadLine();

            Console.WriteLine("\nEnter Vechicle Price ");
            VechPrice = Convert.ToInt32(Console.ReadLine());



            Console.WriteLine("\nEnter Vehicle Accesseries Auxiliary Light Purchase Quantity of Customer ");
            Auxiliary_Light = (Convert.ToInt32(Console.ReadLine()) * 600);

            Console.WriteLine("\nEnter Vehicle Accesseries Bash Plate Purchase Quantity of Customer ");
            Bash_Plate = (Convert.ToInt32(Console.ReadLine()) * 3500);

            Console.WriteLine("\nEnter Vehicle Accesseries Carriers Purchase Quantity of Customer ");
            Carriers = (Convert.ToInt32(Console.ReadLine()) * 990);

            Console.WriteLine("\nEnter Vehicle Accesseries Carsh Guard Purchase Quantity of Customer ");
            Crash_Guard = (Convert.ToInt32(Console.ReadLine()) * 2500);

            Console.WriteLine("\nEnter Vehicle Accesseries Windshield Purchase Quantity of Customer ");
            Windshield = (Convert.ToInt32(Console.ReadLine()) * 350);

            Console.WriteLine("\nEnter Vehicle Accesseries HeadLight Grill Purchase Quantity of Customer ");
            Headlight_Grill = (Convert.ToInt32(Console.ReadLine()) * 1680);

            Console.WriteLine("\nEnter Vehicle Accesseries Leverguard Purchase Quantity of Customer ");
            Leverguards = (Convert.ToInt32(Console.ReadLine()) * 520);

            Total_Price = Auxiliary_Light + Bash_Plate + Carriers + Crash_Guard + Windshield + Headlight_Grill + Leverguards;
            Console.WriteLine("\nTotal Price of Customer Purchase Vehicle Acccesseries  " + Total_Price);

            Address A = new Address(house_pin, b, c, d, e);
            Customer C = new Customer(x, y, z, j, i, A);
            Vehicle V = new Vehicle(ModelNumber, ModelName, VechPrice, Purchas_date);
            VehicleAccesseries VA = new VehicleAccesseries(Auxiliary_Light, Bash_Plate, Carriers, Crash_Guard, Windshield, Headlight_Grill, Leverguards, Total_Price, ModelNumber, ModelName, VechPrice, Purchas_date);
            C.CustomerDetails();
            V.VechicelDetails();
            VA.AccesseriesDitails();


            Console.WriteLine("\n\nEnter 1 For Cash Payment \n\n Enter 2 For Loan Payment");
            int Switch = Convert.ToInt32(Console.ReadLine());
            switch (Switch)
            {
                case 1:
                    Console.WriteLine("\nEnter Mode of Cash Payment");
                    mode_cash = Console.ReadLine();

                    Console.WriteLine("\nEnter Mode Trancation ID");
                    trancatoin = double.Parse(Console.ReadLine());

                    amount = Total_Price + VechPrice;
                    Cash_Billing CB = new Cash_Billing(mode_cash, trancatoin, amount);
                    CB.CashBillingDetails();
                    break;
                   


                case 2:
                    Console.WriteLine("\nEnter Bank Name");
                    Bank_Name = Console.ReadLine();

                    Console.WriteLine("\nEnter Bank Account Number");
                    Bank_Account = double.Parse(Console.ReadLine());

                    Console.WriteLine("\nEnter Bank IFCS Code");
                    Bank_Code = Console.ReadLine();



                    Console.WriteLine("\nEnter Interest Rate");
                    inrate = (double.Parse(Console.ReadLine()) / 1200);

                    Console.WriteLine("\nEnter Tenure Months");
                    year = Convert.ToInt32(Console.ReadLine());

                    VechPrice_addAccess_Price = Total_Price + VechPrice;
                    emi = VechPrice_addAccess_Price * inrate * Math.Pow(1 + inrate, year) / (Math.Pow(1 + inrate, year) - 1);
                    loan_price = (int)emi * year;
                    Bank B = new Bank(Bank_Name, Bank_Account, Bank_Code);
                    LoanBilling L = new LoanBilling(inrate, year, emi, loan_price, Auxiliary_Light, Bash_Plate, Carriers, Crash_Guard, Windshield, Headlight_Grill, Leverguards, Total_Price, ModelNumber, ModelName, VechPrice, Purchas_date);
                    B.BankDetails();
                    L.LoanDetails();
                    break;

                default:
                    Console.WriteLine("Wrong Choice Entered");
                    break;
            }

           
        }
    }
}

            


           







        































    
    
