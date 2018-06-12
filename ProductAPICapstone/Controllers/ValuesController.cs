using ProductAPICapstone.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ProductAPICapstone.Controllers
{
	public class ValuesController : ApiController
	{

		public List<Product> GetProductID(int id)
		{
			NorthwindEntities db = new NorthwindEntities();
			List<Product> prod = db.Products.ToList();

			return prod;
		}

		public string[] GetProductID()
		{
			NorthwindEntities db = new NorthwindEntities();
			List<Product> prod = db.Products.ToList();
			string[] prodArray = new string[prod.Count];

			for (int i = 0; i < prod.Count; i++)
			{
				prodArray[i] = $"Prod id = {prod[i].ProductID} prodname = {prod[i].ProductName}";
			}

			return prodArray;
		}

		public List<Product> GetProducts()
		{
			NorthwindEntities db = new NorthwindEntities();
			List<Product> products = db.Products.ToList();

			return products;
		}

		//public List<Product> 
		// GET api/values
		public IEnumerable<string> Get()
		{
			return new string[] { "value1", "value2" };
		}

		// GET api/values/5
		public string Get(int id)
		{
			return "value";
		}

		// POST api/values
		public void Post([FromBody]string value)
		{
		}

		// PUT api/values/5
		public void Put(int id, [FromBody]string value)
		{
		}

		// DELETE api/values/5
		public void Delete(int id)
		{
		}
	}
}
