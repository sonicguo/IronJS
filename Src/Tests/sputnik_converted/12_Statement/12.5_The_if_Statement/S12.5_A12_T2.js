// Copyright 2009 the Sputnik authors.  All rights reserved.
// This code is governed by the BSD license found in the LICENSE file.

/**
* @name: S12.5_A12_T2;
* @section: 12.5;
* @assertion: Embedded "if/else" constructions are allowed;
* @description: Using embedded "if" into "if/else" constructions;
*/


// Converted for Test262 from original Sputnik source

ES5Harness.registerTest( {
id: "S12.5_A12_T2",

path: "TestCases/12_Statement/12.5_The_if_Statement/S12.5_A12_T2.js",

assertion: "Embedded \"if/else\" constructions are allowed",

description: "Using embedded \"if\" into \"if/else\" constructions",

test: function testcase() {
   //CHECK# 1
if(true){
  if (false)
    $ERROR('#1.1: At embedded "if/else" constructions engine must select right branches');
}
else{ 
  if (true)
    $ERROR('#1.2: At embedded "if/else" constructions engine must select right branches');
}

//CHECK# 2
if(true){
  if (true)
    ;
}
else{ 
  if (true)
    $ERROR('#2.2: At embedded "if/else" constructions engine must select right branches');
}

//CHECK# 3
if(false){
  if (true)
    $ERROR('#3.1: At embedded "if/else" constructions engine must select right branches');
}
else{ 
  if (true)
    ;
}

//CHECK# 4
if(false){
  if (true)
    $ERROR('#4.1: At embedded "if/else" constructions engine must select right branches');
}
else{ 
  if (false)
    $ERROR('#4.3: At embedded "if/else" constructions engine must select right branches');
}

 }
});
