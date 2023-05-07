using System.Data;
using System.Data.SqlClient;
using PizzaApp.Constants;
#region ConsoleApp

//Console.WriteLine("Please choose");
//Console.WriteLine("1-Check out the pizzas on the menu");
//Console.WriteLine("2-Create a new pizza");
//int ans = Convert.ToInt32(Console.ReadLine());
//if (ans == 1) 
//{


//}
//else if (ans == 2) 
//{

//}
//else 
//{ 

//}



//Name tek cixarmaq ucun istifade olunur 
#endregion


//int b = Convert.ToInt32(Console.ReadLine());
//if (b == 1)
//{
//    for (int i = 0; i < 16; i++)
//    {
//        //GetName(i);
//        GetId(i);
//    }
//}
GetName("1");
Console.ReadLine();
 void GetName(string id)
{
    

        using (SqlConnection sqlConnection = new SqlConnection(Urls.constr))
        {
            sqlConnection.Open();
            string commondtext = "select Pizzas.Id,Pizzas.Name,Prices.SizeId,Prices.Price from Pizzas join Prices on Pizzas.Id=Prices.Id\r\n";
            using (SqlCommand cmd = new SqlCommand(commondtext, sqlConnection))
            {
                //cmd.Parameters.AddWithValue("Id", SqlDbType.Int).Value = id;
                string name = (string)( cmd.ExecuteScalar());
                Console.WriteLine(name);
            }



        }
        
}
 
//async void InsertPizza(string name, string surname)
//{
//    using (SqlConnection sqlConnection = new SqlConnection(constr))
//    {
//        sqlConnection.Open();
//        string commondtext = "insert into Pizzas values(@name,)";
//        using (SqlCommand cmd = new SqlCommand(commondtext, sqlConnection))
//        {

//        }

//    }
//}
