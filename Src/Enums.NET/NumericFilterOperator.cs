﻿// Enums.NET
// Copyright 2015 Tyler Brinkley. All rights reserved.
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//    http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

using System;
using System.ComponentModel;

namespace EnumsNET.Test
{
	// Duplicate example
	public enum NumericFilterOperator
	{
		[NumericFilterOperatorType(NumericFilterOperatorType.OneNumber)]
		Is = 0,
		[NumericFilterOperatorType(NumericFilterOperatorType.OneNumber)]
		IsNot,
		[NumericFilterOperatorType(NumericFilterOperatorType.OneNumber)]
		GreaterThan,
		[NumericFilterOperatorType(NumericFilterOperatorType.OneNumber)]
		LessThan,
		[MainDuplicate]
		[NumericFilterOperatorType(NumericFilterOperatorType.OneNumber)]
		[Description("Greater than or equal")]
		GreaterThanOrEqual,
		[NumericFilterOperatorType(NumericFilterOperatorType.OneNumber)]
		[Description("Not less than")]
		NotLessThan = GreaterThanOrEqual,
		[NumericFilterOperatorType(NumericFilterOperatorType.OneNumber)]
		LessThanOrEqual,
		[MainDuplicate]
		[NumericFilterOperatorType(NumericFilterOperatorType.OneNumber)]
		NotGreaterThan = LessThanOrEqual,
		[NumericFilterOperatorType(NumericFilterOperatorType.TwoNumbers)]
		Between,
		[NumericFilterOperatorType(NumericFilterOperatorType.TwoNumbers)]
		NotBetween
	}

	public enum NumericFilterOperatorType
	{
		OneNumber = 0,
		TwoNumbers
	}

	[AttributeUsage(AttributeTargets.Field)]
	public class NumericFilterOperatorTypeAttribute : Attribute
	{
		public NumericFilterOperatorType Type { get; }

        public NumericFilterOperatorTypeAttribute(NumericFilterOperatorType type)
		{
			Type = type;
		}
	}
}