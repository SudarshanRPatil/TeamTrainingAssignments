
//  Microsoft (R) .NET Framework IL Disassembler.  Version 4.6.1055.0
//  Copyright (c) Microsoft Corporation.  All rights reserved.



// Metadata version: v4.0.30319
.assembly extern mscorlib
{
  .publickeytoken = (B7 7A 5C 56 19 34 E0 89 )                         // .z\V.4..
  .ver 4:0:0:0
}
.assembly MyApp
{
  .custom instance void [mscorlib]System.Runtime.CompilerServices.CompilationRelaxationsAttribute::.ctor(int32) = ( 01 00 08 00 00 00 00 00 ) 
  .custom instance void [mscorlib]System.Runtime.CompilerServices.RuntimeCompatibilityAttribute::.ctor() = ( 01 00 01 00 54 02 16 57 72 61 70 4E 6F 6E 45 78   // ....T..WrapNonEx
                                                                                                             63 65 70 74 69 6F 6E 54 68 72 6F 77 73 01 )       // ceptionThrows.

  // --- The following custom attribute is added automatically, do not uncomment -------
  //  .custom instance void [mscorlib]System.Diagnostics.DebuggableAttribute::.ctor(valuetype [mscorlib]System.Diagnostics.DebuggableAttribute/DebuggingModes) = ( 01 00 07 01 00 00 00 00 ) 

  .hash algorithm 0x00008004
  .ver 0:0:0:0
}
.module MyApp.exe
// MVID: {D0D32E94-804F-4E35-9FAE-F035CE6B323E}
.imagebase 0x00400000
.file alignment 0x00000200
.stackreserve 0x00100000
.subsystem 0x0003       // WINDOWS_CUI
.corflags 0x00000001    //  ILONLY
// Image base: 0x00370000


// =============== CLASS MEMBERS DECLARATION ===================

.class public auto ansi beforefieldinit MyApp.Program
       extends [mscorlib]System.Object
{
  .method public hidebysig static void  Main(string[] args) cil managed
  {
    .entrypoint
    // Code size       88 (0x58)
    .maxstack  4
    .locals init (int32 V_0,
             bool V_1)
    IL_0000:  nop
    IL_0001:  ldstr      "Hello World, Current date time is {0}"
    IL_0006:  call       valuetype [mscorlib]System.DateTime [mscorlib]System.DateTime::get_Now()
    IL_000b:  box        [mscorlib]System.DateTime
    IL_0010:  call       void [mscorlib]System.Console::WriteLine(string,
                                                                  object)
    IL_0015:  nop
    IL_0016:  ldstr      "parameter count = {0}"
    IL_001b:  ldarg.0
    IL_001c:  ldlen
    IL_001d:  conv.i4
    IL_001e:  box        [mscorlib]System.Int32
    IL_0023:  call       void [mscorlib]System.Console::WriteLine(string,
                                                                  object)
    IL_0028:  nop
    IL_0029:  ldc.i4.0
    IL_002a:  stloc.0
    IL_002b:  br.s       IL_0047

    IL_002d:  nop
    IL_002e:  ldstr      "Arg[{0}] = [{1}]"
    IL_0033:  ldloc.0
    IL_0034:  box        [mscorlib]System.Int32
    IL_0039:  ldarg.0
    IL_003a:  ldloc.0
    IL_003b:  ldelem.ref
    IL_003c:  call       void [mscorlib]System.Console::WriteLine(string,
                                                                  object,
                                                                  object)
    IL_0041:  nop
    IL_0042:  nop
    IL_0043:  ldloc.0
    IL_0044:  ldc.i4.1
    IL_0045:  add
    IL_0046:  stloc.0
    IL_0047:  ldloc.0
    IL_0048:  ldarg.0
    IL_0049:  ldlen
    IL_004a:  conv.i4
    IL_004b:  clt
    IL_004d:  stloc.1
    IL_004e:  ldloc.1
    IL_004f:  brtrue.s   IL_002d

    IL_0051:  call       valuetype [mscorlib]System.ConsoleKeyInfo [mscorlib]System.Console::ReadKey()
    IL_0056:  pop
    IL_0057:  ret
  } // end of method Program::Main

  .method public hidebysig specialname rtspecialname 
          instance void  .ctor() cil managed
  {
    // Code size       8 (0x8)
    .maxstack  8
    IL_0000:  ldarg.0
    IL_0001:  call       instance void [mscorlib]System.Object::.ctor()
    IL_0006:  nop
    IL_0007:  ret
  } // end of method Program::.ctor

} // end of class MyApp.Program


// =============================================================

// *********** DISASSEMBLY COMPLETE ***********************
// WARNING: Created Win32 resource file E:\WorkArea\CodeBase\TeamTrainingAssignments\DayOneAssignment\MyApp.res
