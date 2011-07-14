// Copyright 2009 the Sputnik authors.  All rights reserved.
// This code is governed by the BSD license found in the LICENSE file.

/**
 * @name: S9.6_A3.1_T3;
 * @section: 9.6;
 * @assertion: Operator uses ToNumber;
 * @description: Type(x) is String; 
*/


// Converted for Test262 from original Sputnik source

ES5Harness.registerTest( {
id: "S9.6_A3.1_T3",

path: "TestCases/09_Type_Conversion/9.6_ToUint32/S9.6_A3.1_T3.js",

assertion: "Operator uses ToNumber",

description: "Type(x) is String",

test: function testcase() {
   // CHECK#1
if ((new String(1) >>> 0) !== 1) {
  $ERROR('#1: (new String(1) >>> 0) === 1. Actual: ' + ((new String(1) >>> 0)));
}

// CHECK#2
if (("-1.234" >>> 0) !== 4294967295) {
  $ERROR('#2: ("-1.234" >>> 0) === 4294967295. Actual: ' + (("-1.234" >>> 0)));
}

 }
});
