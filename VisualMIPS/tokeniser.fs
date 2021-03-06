﻿namespace VisualMIPS

module Tokeniser =

    /// Tokenise single string/line into Tokens
    let tokenise (s: string) = 
        let nocomment = s.Split('#').[0]
        Array.filter ((<>) "") (nocomment.Split(' ',',','(',')','\t','\n','\r','\f'))

    /// Splits large string into lines NOT NEEDED
    let split (input: string) =
        Array.filter ((<>) "") (input.Split('\n','\r','\f'))

    // Tokeniser does not handle error checking. This is done by the parser when it checks each parameter.