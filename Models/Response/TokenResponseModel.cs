﻿namespace ptm_store_service.Models.Response
{
    public class TokenResponseModel
    {
        public int Id {  get; set; }
        public string AccessToken { get; set; }
        public string RefreshToken { get; set; }
        public int UserId { get; set; }
    }
}
