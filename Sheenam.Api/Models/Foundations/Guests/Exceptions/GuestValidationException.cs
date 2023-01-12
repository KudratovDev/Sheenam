﻿//=================================================
// Copyright(c) Coalition of Good-Hearted Engineers
// Free To Use To Find Comfort and Peace
//=================================================

using System.ComponentModel;
using Xeptions;

namespace Sheenam.Api.Models.Foundations.Guests.Exceptions
{
    public class GuestValidationException : Xeption
    {
        public GuestValidationException(Xeption innerException)
            : base(message: "Guest validation error occurred, fix errors and try again",
                  innerException)
        { }
    }
}
