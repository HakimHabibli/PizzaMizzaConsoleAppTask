using System.Data;
using System.Data.SqlClient;
using PizzaApp.Constants;
#region ConsoleApp

Console.WriteLine("Please choose");
Console.WriteLine("1-Check out the pizzas on the menu");
Console.WriteLine("2-Create a new pizza");
int ans = Convert.ToInt32(Console.ReadLine());
if (ans == 1)
{
    Start:
    GetInfosForStepone();
    Console.Read();
    Console.WriteLine("Pizzalar haqqinda etrafli melumat almaq isteyirsiz ? Yes/No");
    string ans1 = Convert.ToString(Console.ReadLine());
    if (ans1.ToLower() == "yes")
    {
        Console.WriteLine("Pls enter the pizza's Id");
        int ans3 = Convert.ToInt32(Console.ReadLine());
        GetInfosForSteptwo(ans3);

    }
    else if (ans1.ToLower() == "no")
    {
        goto Start;
    }
    else 
    { 
    
    }
}
else if (ans == 2)
{

}
else
{

}




#endregion


Console.ReadLine();


void GetInfosForStepone() 
{
    using (SqlConnection con = new SqlConnection(Urls.constr))
    {
        con.Open();
        //Tipini ve qiymeti ucun commondTexte sql joini yazilmalidi
        string commmondText = "SELECT p.Id , p.Name , pt.TypeId , ps.Price from Pizzas as p\r\nInner Join PizzaTypes as pt\r\non p.Id = pt.PizzaId\r\nInner join Prices as ps \r\non ps.PizzaId = p.Id";
        using (SqlCommand cmd = new SqlCommand(commmondText,con))
        {
            using
            (SqlDataReader reader = cmd.ExecuteReader())
            {
                if (reader.HasRows) 
                {
                    while (reader.Read())
                    {
                        Console.WriteLine($"{reader[0]} - {reader[1]}");
                    }
                }
                else { Console.WriteLine("Table empty"); }
            }
        }
    }
}

void GetInfosForSteptwo(int id)
{
    using (SqlConnection con2 = new SqlConnection(Urls.constr))
    {
        con2.Open();
        //Tipini ve qiymeti ucun commondTexte sql joini yazilmalidi
        string commmondText = "";
        using (SqlCommand cmd = new SqlCommand(commmondText, con2))
        {
            using
            (SqlDataReader reader = cmd.ExecuteReader())
            {
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        Console.WriteLine($"{reader[0]} - {reader[1]}");
                    }
                }
                else { Console.WriteLine("Table empty"); }
            }
        }
    }
}





//void GetName()
//{


//    using (SqlConnection sqlConnection = new SqlConnection(Urls.constr))
//    {
//        sqlConnection.Open();
//        string commondtext = "select Pizzas.Id,Pizzas.Name,Prices.SizeId,Prices.Price from Pizzas join Prices on Pizzas.Id=Prices.Id\r\n";
//        using (SqlCommand cmd = new SqlCommand(commondtext, sqlConnection))
//        {
//            //cmd.Parameters.AddWithValue("Id", SqlDbType.Int).Value = id;
//            string name = (string)(cmd.ExecuteScalar());
//            Console.WriteLine(name);
//        }



//    }

//}

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
