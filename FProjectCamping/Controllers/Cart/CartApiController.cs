﻿
using FProjectCamping.Models.EFModels;
using FProjectCamping.Models.Services;
using FProjectCamping.Models.ViewModels.Carts;
using FProjectCamping.Models.ViewModels.Rooms;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Net.Http.Formatting;




namespace FProjectCamping.Controllers.Cart
{
	public class CartApiController : ApiController
	{
		[HttpPost]
		[Route("api/Cart/AddCartItem")]
		public IHttpActionResult AddCartItem([FromBody] CartItemsVm requestData)
		{
			var service = new CartService();
			string buyer = User.Identity.Name; // 買家帳號
			var result = service.AddToCart(buyer, requestData); //加入購物車


			return Ok(result);
		}


		//[HttpPost]
		//[Route("api/Cart/AddCartItem")]
		//public IHttpActionResult AddCartItem([FromBody] CartItemRequestModel requestData)
		//{
		//	var db = new AppDbContext();

		//	if (ModelState.IsValid)
		//	{

		//		var cartItem = new CartItem
		//		{
		//			CartId = requestData.cartId,
		//			RoomId = requestData.roomId,
		//			CheckInDate = requestData.checkInDate,
		//			CheckOutDate = requestData.checkOutDate,
		//			ExtraBed = requestData.extraBed,
		//			ExtraBedPrice = requestData.extraBedPrice,
		//			Days = requestData.days,
		//			SubTotal = requestData.subtotal
		//		};

		//		db.CartItems.Add(cartItem);
		//		db.SaveChanges();


		//		return Ok();
		//	}

		//	else
		//	{
		//		return BadRequest(ModelState);
		//	}
		//}
	}
}
