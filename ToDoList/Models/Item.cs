namespace ToDoList.Models
{
  public class Item
  {
    public int ItemId { get; set; }
    public string Description { get; set; }

    // public Item(string description)
    // {
    //   Description = description;
    // }
    // public Item(string description, int id)
    // {
    //   Description = description;
    //   Id = id;
    // }

    // public override bool Equals(System.Object otherItem)
    // {
    //   if (!(otherItem is Item))
    //   {
    //     return false;
    //   }
    //   else
    //   {
    //     Item newItem = (Item) otherItem;
    //     bool idEquality = (this.Id == newItem.Id);
    //     bool descriptionEquality = (this.Description == newItem.Description);
    //     return (idEquality && descriptionEquality);
    //   }
    // }

    // public void Save()
    // {
    //   MySqlConnection conn = DB.Connection();
    //   conn.Open();
    //   MySqlCommand cmd = conn.CreateCommand() as MySqlCommand;

    //   cmd.CommandText = "INSERT INTO items (description) VALUES (@ItemDescription);";
    //   MySqlParameter param = new MySqlParameter();
    //   param.ParameterName = "@ItemDescription";
    //   param.Value = this.Description;
    //   cmd.Parameters.Add(param);    
    //   cmd.ExecuteNonQuery();
    //   Id = (int) cmd.LastInsertedId;

    //   conn.Close();
    //   if (conn != null)
    //   {
    //     conn.Dispose();
    //   }
    // }

    // public static Item Find(int id)
    // {
    //   MySqlConnection conn = DB.Connection();
    //   conn.Open();

    //   MySqlCommand cmd = conn.CreateCommand() as MySqlCommand;
    //   cmd.CommandText = "SELECT * FROM `items` WHERE id = @ThisId;";

    //   MySqlParameter param = new MySqlParameter();
    //   param.ParameterName = "@ThisId";
    //   param.Value = id;
    //   cmd.Parameters.Add(param);

    //   MySqlDataReader rdr = cmd.ExecuteReader() as MySqlDataReader;
    //   int itemId = 0;
    //   string itemDescription = "";
    //   while (rdr.Read())
    //   {
    //     itemId = rdr.GetInt32(0);
    //     itemDescription = rdr.GetString(1);
    //   }
    //   Item foundItem = new Item(itemDescription, itemId);

    //   conn.Close();
    //   if (conn != null)
    //   {
    //     conn.Dispose();
    //   }
    //   return foundItem;
    // }

    // public static List<Item> GetAll()
    // {
    //   List<Item> allItems = new List<Item> { };
    //   MySqlConnection conn = DB.Connection();
    //   conn.Open();
    //   MySqlCommand cmd = conn.CreateCommand() as MySqlCommand;
    //   cmd.CommandText = "SELECT * FROM items;";
    //   MySqlDataReader rdr = cmd.ExecuteReader() as MySqlDataReader;
    //   while (rdr.Read())
    //   {
    //       int itemId = rdr.GetInt32(0);
    //       string itemDescription = rdr.GetString(1);
    //       Item newItem = new Item(itemDescription, itemId);
    //       allItems.Add(newItem);
    //   }
    //   conn.Close();
    //   if (conn != null)
    //   {
    //       conn.Dispose();
    //   }
    //   return allItems;
    // }

    // public static void ClearAll()
    // {
    //   MySqlConnection conn = DB.Connection();
    //   conn.Open();
    //   MySqlCommand cmd = conn.CreateCommand() as MySqlCommand;
    //   cmd.CommandText = "DELETE FROM items;";
    //   cmd.ExecuteNonQuery();
    //   conn.Close();
    //   if (conn != null)
    //   {
    //    conn.Dispose();
    //   }
    // }
  }
}
