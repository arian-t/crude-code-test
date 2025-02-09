﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace CrudTest.Application.Common.Models
{
    /**
     * A response type for request with side effects but no info (i.e Create/Delete)
     */
    public class Result
    {
        internal Result(bool succeeded, IEnumerable<string> errors)
        {
            Succeeded = succeeded;
            Errors = errors.ToArray();
        }

        public bool Succeeded { get; set; }

        public string[] Errors { get; set; }

        public static Result Success()
        {
            return new Result(true, Array.Empty<string>());
        }

        public static Result Failure(IEnumerable<string> errors)
        {
            return new Result(false, errors);
        }
    }
}