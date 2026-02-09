internal class Program
{
    private static void Main(string[] args)
    {
        char tryAgain;
        do
        {
            Console.Write("enter the payment amount : ");
            double paymentAmount = Convert.ToDouble(Console.ReadLine());
            double paymentAfterDiscount = paymentAmount;
            if (paymentAmount < 0)
            {
                Console.WriteLine($" invalid bill amount ");
            }
          else if (paymentAmount >= 500)
            {
                paymentAfterDiscount = paymentAfterDiscount - paymentAmount * 0.2;
            }
            else if (paymentAmount >= 300 && paymentAmount < 500)
            {
                paymentAfterDiscount = paymentAfterDiscount - paymentAmount * 0.1;
            }
            else if (paymentAmount < 300)
            {
                paymentAfterDiscount = paymentAmount;
            }
            DateTime paymentTime = DateTime.Now;
            string payment_Time = paymentTime.ToString("dd-MM-yyyy hh:mm:ss tt");
            Guid paymentId = Guid.NewGuid();

            Console.WriteLine($"the final price is : {paymentAfterDiscount} \npayment time : {payment_Time}");
            Console.WriteLine($"your bill Id {paymentId} ");
            Console.Write($"do you have another payment y/n ? ");
          
             tryAgain = Convert.ToChar( Console.ReadLine());
         
        }
        while (tryAgain == 'y');
        /*
         * i faced a problem in the tryAgain var 
         * the var was inside the (do) loop thats why it didnt work
         * i asked chatgpt to fix and explain it 
         * thats the only AI help i used 
         *
         */
    }
}