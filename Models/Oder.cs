﻿namespace OrderAPI.Models;
public class Order
{
    public int Id { get; set; }
    public string ItemName { get; set; }
    public int Quantity { get; set; }
    public DateTime DeliveryTime { get; set; }
    public string DeliveryAddress { get; set; }
    public string ContactPhone { get; set; }
}
