﻿using System;

namespace auctionModels
{
    public class Artist
    {
        private string countryCode="";
        int id;
        string name = "";
        string biography = "";
        public bool registered { get; set; }
        public int Id { get { return id; } set { id = value; } }
        public string Name { get { return name; } set { name = value; } }
        public string Biography { get { return biography; } set { biography = value; } }
        public string ArtistStatement { get; set; }
        public string Location { get; set; }
        public string CountryCode {
            get { return countryCode;
            }
            set{
                countryCode = value;
            }
        }
        public Art[] Gallery;
        Signature signature;
        public override string ToString()
        {
            string s = $"Artist:\nId={Id}\nname={name}\nbiography{biography}=";
  
            return s;
        }
    }
}