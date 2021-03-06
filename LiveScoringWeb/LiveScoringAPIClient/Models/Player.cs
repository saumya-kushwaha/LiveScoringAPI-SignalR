﻿// Code generated by Microsoft (R) AutoRest Code Generator 0.9.7.0
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

using System;
using System.Linq;
using Newtonsoft.Json.Linq;

namespace LiveScoringWeb.LiveScoringAPI.Models
{
    public partial class Player
    {
        private string _match;
        
        /// <summary>
        /// Required.
        /// </summary>
        public string Match
        {
            get { return this._match; }
            set { this._match = value; }
        }
        
        private string _name;
        
        /// <summary>
        /// Required.
        /// </summary>
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }
        
        private int _score;
        
        /// <summary>
        /// Required.
        /// </summary>
        public int Score
        {
            get { return this._score; }
            set { this._score = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the Player class.
        /// </summary>
        public Player()
        {
        }
        
        /// <summary>
        /// Initializes a new instance of the Player class with required
        /// arguments.
        /// </summary>
        public Player(string name, int score, string match)
            : this()
        {
            if (name == null)
            {
                throw new ArgumentNullException("name");
            }
            if (match == null)
            {
                throw new ArgumentNullException("match");
            }
            this.Name = name;
            this.Score = score;
            this.Match = match;
        }
        
        /// <summary>
        /// Serialize the object
        /// </summary>
        /// <returns>
        /// Returns the json model for the type Player
        /// </returns>
        public virtual JToken SerializeJson(JToken outputObject)
        {
            if (outputObject == null)
            {
                outputObject = new JObject();
            }
            if (this.Match == null)
            {
                throw new ArgumentNullException("Match");
            }
            if (this.Name == null)
            {
                throw new ArgumentNullException("Name");
            }
            if (this.Match != null)
            {
                outputObject["Match"] = this.Match;
            }
            if (this.Name != null)
            {
                outputObject["Name"] = this.Name;
            }
            outputObject["Score"] = this.Score;
            return outputObject;
        }
    }
}
