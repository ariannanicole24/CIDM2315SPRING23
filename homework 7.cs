using System;
        class Customer{
            private int cus_id;

            public string cus_name;

            public int cus_age;

            
                public Customer(int id, string name, int age) {
                    cus_id = id;
                    cus_name = name;
                    cus_age = age;
                }
                public void ChangeID(int new_id) {
                    cus_id = new_id;
                }
                public void PrintCusInfo(){
                    Console.WriteLine("Customer : " + cus_id + " name : " + cus_age + " age : " + cus_age);
                }
            
        
    }

class HellowWorld {
    static void Main(){
        Customer cust1 =  new Customer(110, "Alice", 28);
        cust1.PrintCusInfo();
        Customer cust2 = new Customer(111, "Bob", 30);
        cust2.PrintCusInfo();
        cust1.ChangeID(220);
        cust2.ChangeID(221);

        cust1.PrintCusInfo();
        cust2.PrintCusInfo();

    }
}
