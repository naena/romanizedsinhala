Sub OSPP()
    '
    ' OSPP Macro
    ' Macro recorded 11/4/2006 by JC
    ' This attempts to make an HTML file
    '
    Selection.WholeStory()
    Selection.Range.Case = wdLowerCase
    Selection.HomeKey(Unit:=wdStory)
    Selection.Find.ClearFormatting()
    Selection.Find.Replacement.ClearFormatting()
    With Selection.Find
        .Text = "þ"
        .Replacement.Text = "w"
        .Forward = True
        .Wrap = wdFindContinue
        .Format = False
        .MatchCase = False
        .MatchWholeWord = False
        .MatchWildcards = False
        .MatchSoundsLike = False
        .MatchAllWordForms = False
    End With
    Selection.Find.Execute(Replace:=wdReplaceAll)
    With Selection.Find
        .Text = "t"
        .Replacement.Text = "þ"
        .Forward = True
        .Wrap = wdFindContinue
        .Format = False
        .MatchCase = False
        .MatchWholeWord = False
        .MatchWildcards = False
        .MatchSoundsLike = False
        .MatchAllWordForms = False
    End With
    Selection.Find.Execute(Replace:=wdReplaceAll)
    With Selection.Find
        .Text = "d"
        .Replacement.Text = "ð"
        .Forward = True
        .Wrap = wdFindAsk
        .Format = False
        .MatchCase = False
        .MatchWholeWord = False
        .MatchWildcards = False
        .MatchSoundsLike = False
        .MatchAllWordForms = False
    End With
    Selection.Find.Execute(Replace:=wdReplaceAll)
    With Selection.Find
        .Text = "aü"
        .Replacement.Text = "á"
        .Forward = True
        .Wrap = wdFindContinue
        .Format = False
        .MatchCase = False
        .MatchWholeWord = False
        .MatchWildcards = False
        .MatchSoundsLike = False
        .MatchAllWordForms = False
    End With
    Selection.Find.Execute(Replace:=wdReplaceAll)
    With Selection.Find
        .Text = "iü"
        .Replacement.Text = "í"
        .Forward = True
        .Wrap = wdFindContinue
        .Format = False
        .MatchCase = False
        .MatchWholeWord = False
        .MatchWildcards = False
        .MatchSoundsLike = False
        .MatchAllWordForms = False
    End With
    Selection.Find.Execute(Replace:=wdReplaceAll)
    With Selection.Find
        .Text = "uü"
        .Replacement.Text = "ú"
        .Forward = True
        .Wrap = wdFindAsk
        .Format = False
        .MatchCase = False
        .MatchWholeWord = False
        .MatchWildcards = False
        .MatchSoundsLike = False
        .MatchAllWordForms = False
    End With
    Selection.Find.Execute(Replace:=wdReplaceAll)
    With Selection.Find
        .Text = "eü"
        .Replacement.Text = "é"
        .Forward = True
        .Wrap = wdFindAsk
        .Format = False
        .MatchCase = False
        .MatchWholeWord = False
        .MatchWildcards = False
        .MatchSoundsLike = False
        .MatchAllWordForms = False
    End With
    Selection.Find.Execute(Replace:=wdReplaceAll)
    With Selection.Find
        .Text = "ó"
        .Replacement.Text = "d"
        .Forward = True
        .Wrap = wdFindContinue
        .Format = False
        .MatchCase = False
        .MatchWholeWord = False
        .MatchWildcards = False
        .MatchSoundsLike = False
        .MatchAllWordForms = False
    End With
    Selection.Find.Execute(Replace:=wdReplaceAll)
    With Selection.Find
        .Text = "oü"
        .Replacement.Text = "ó"
        .Forward = True
        .Wrap = wdFindAsk
        .Format = False
        .MatchCase = False
        .MatchWholeWord = False
        .MatchWildcards = False
        .MatchSoundsLike = False
        .MatchAllWordForms = False
    End With
    Selection.Find.Execute(Replace:=wdReplaceAll)
    With Selection.Find
        .Text = "õ"
        .Replacement.Text = "µ"
        .Forward = True
        .Wrap = wdFindAsk
        .Format = False
        .MatchCase = False
        .MatchWholeWord = False
        .MatchWildcards = False
        .MatchSoundsLike = False
        .MatchAllWordForms = False
    End With
    Selection.Find.Execute(Replace:=wdReplaceAll)
    With Selection.Find
        .Text = "à"
        .Replacement.Text = "aa"
        .Forward = True
        .Wrap = wdFindAsk
        .Format = False
        .MatchCase = False
        .MatchWholeWord = False
        .MatchWildcards = False
        .MatchSoundsLike = False
        .MatchAllWordForms = False
    End With
    Selection.Find.Execute(Replace:=wdReplaceAll)
    With Selection.Find
        .Text = "ã"
        .Replacement.Text = "ii"
        .Forward = True
        .Wrap = wdFindAsk
        .Format = False
        .MatchCase = False
        .MatchWholeWord = False
        .MatchWildcards = False
        .MatchSoundsLike = False
        .MatchAllWordForms = False
    End With
    Selection.Find.Execute(Replace:=wdReplaceAll)
    With Selection.Find
        .Text = "å"
        .Replacement.Text = "uu"
        .Forward = True
        .Wrap = wdFindAsk
        .Format = False
        .MatchCase = False
        .MatchWholeWord = False
        .MatchWildcards = False
        .MatchSoundsLike = False
        .MatchAllWordForms = False
    End With
    Selection.Find.Execute(Replace:=wdReplaceAll)
    With Selection.Find
        .Text = "â"
        .Replacement.Text = "aa"
        .Forward = True
        .Wrap = wdFindAsk
        .Format = False
        .MatchCase = False
        .MatchWholeWord = False
        .MatchWildcards = False
        .MatchSoundsLike = False
        .MatchAllWordForms = False
    End With
    Selection.Find.Execute(Replace:=wdReplaceAll)
    With Selection.Find
        .Text = "ç"
        .Replacement.Text = "ü"
        .Forward = True
        .Wrap = wdFindAsk
        .Format = False
        .MatchCase = False
        .MatchWholeWord = False
        .MatchWildcards = False
        .MatchSoundsLike = False
        .MatchAllWordForms = False
    End With
    Selection.Find.Execute(Replace:=wdReplaceAll)
    With Selection.Find
        .Text = "¤"
        .Replacement.Text = "ç"
        .Forward = True
        .Wrap = wdFindAsk
        .Format = False
        .MatchCase = False
        .MatchWholeWord = False
        .MatchWildcards = False
        .MatchSoundsLike = False
        .MatchAllWordForms = False
    End With
    Selection.Find.Execute(Replace:=wdReplaceAll)
    With Selection.Find
        .Text = "ñ"
        .Replacement.Text = "t"
        .Forward = True
        .Wrap = wdFindContinue
        .Format = False
        .MatchCase = False
        .MatchWholeWord = False
        .MatchWildcards = False
        .MatchSoundsLike = False
        .MatchAllWordForms = False
    End With
    Selection.Find.Execute(Replace:=wdReplaceAll)
    With Selection.Find
        .Text = "ø"
        .Replacement.Text = "z"
        .Forward = True
        .Wrap = wdFindContinue
        .Format = False
        .MatchCase = False
        .MatchWholeWord = False
        .MatchWildcards = False
        .MatchSoundsLike = False
        .MatchAllWordForms = False
    End With
    Selection.Find.Execute(Replace:=wdReplaceAll)
    With Selection.Find
        .Text = "ë"
        .Replacement.Text = "ø"
        .Forward = True
        .Wrap = wdFindContinue
        .Format = False
        .MatchCase = False
        .MatchWholeWord = False
        .MatchWildcards = False
        .MatchSoundsLike = False
        .MatchAllWordForms = False
    End With
    Selection.Find.Execute(Replace:=wdReplaceAll)
    With Selection.Find
        .Text = "ï"
        .Replacement.Text = "ñ"
        .Forward = True
        .Wrap = wdFindAsk
        .Format = False
        .MatchCase = False
        .MatchWholeWord = False
        .MatchWildcards = False
        .MatchSoundsLike = False
        .MatchAllWordForms = False
    End With
    Selection.Find.Execute(Replace:=wdReplaceAll)
    With Selection.Find
        .Text = "ö"
        .Replacement.Text = "o"
        .Forward = True
        .Wrap = wdFindAsk
        .Format = False
        .MatchCase = False
        .MatchWholeWord = False
        .MatchWildcards = False
        .MatchSoundsLike = False
        .MatchAllWordForms = False
    End With
    Selection.Find.Execute(Replace:=wdReplaceAll)
    With Selection.Find
        .Text = "ù"
        .Replacement.Text = "x"
        .Forward = True
        .Wrap = wdFindAsk
        .Format = False
        .MatchCase = False
        .MatchWholeWord = False
        .MatchWildcards = False
        .MatchSoundsLike = False
        .MatchAllWordForms = False
    End With
    Selection.Find.Execute(Replace:=wdReplaceAll)
    With Selection.Find
        .Text = "÷"
        .Replacement.Text = "z"
        .Forward = True
        .Wrap = wdFindAsk
        .Format = False
        .MatchCase = False
        .MatchWholeWord = False
        .MatchWildcards = False
        .MatchSoundsLike = False
        .MatchAllWordForms = False
    End With
    Selection.Find.Execute(Replace:=wdReplaceAll)
    With Selection.Find
        .Text = "ß"
        .Replacement.Text = ""
        .Forward = True
        .Wrap = wdFindAsk
        .Format = False
        .MatchCase = False
        .MatchWholeWord = False
        .MatchWildcards = False
        .MatchSoundsLike = False
        .MatchAllWordForms = False
    End With
    Selection.Find.Execute(Replace:=wdReplaceAll)
    With Selection.Find
        .Text = "û"
        .Replacement.Text = ""
        .Forward = True
        .Wrap = wdFindAsk
        .Format = False
        .MatchCase = False
        .MatchWholeWord = False
        .MatchWildcards = False
        .MatchSoundsLike = False
        .MatchAllWordForms = False
    End With
    Selection.Find.Execute(Replace:=wdReplaceAll)
    With Selection.Find
        .Text = "aw"
        .Replacement.Text = "ä"
        .Forward = True
        .Wrap = wdFindAsk
        .Format = False
        .MatchCase = False
        .MatchWholeWord = False
        .MatchWildcards = False
        .MatchSoundsLike = False
        .MatchAllWordForms = False
    End With
    Selection.Find.Execute(Replace:=wdReplaceAll)
    With Selection.Find
        .Text = "ew"
        .Replacement.Text = "ë"
        .Forward = True
        .Wrap = wdFindAsk
        .Format = False
        .MatchCase = False
        .MatchWholeWord = False
        .MatchWildcards = False
        .MatchSoundsLike = False
        .MatchAllWordForms = False
    End With
    Selection.Find.Execute(Replace:=wdReplaceAll)
    With Selection.Find
        .Text = "uw"
        .Replacement.Text = "ü"
        .Forward = True
        .Wrap = wdFindAsk
        .Format = False
        .MatchCase = False
        .MatchWholeWord = False
        .MatchWildcards = False
        .MatchSoundsLike = False
        .MatchAllWordForms = False
    End With
    Selection.Find.Execute(Replace:=wdReplaceAll)
    With Selection.Find
        .Text = "iw"
        .Replacement.Text = "ï"
        .Forward = True
        .Wrap = wdFindAsk
        .Format = False
        .MatchCase = False
        .MatchWholeWord = False
        .MatchWildcards = False
        .MatchSoundsLike = False
        .MatchAllWordForms = False
    End With
    Selection.Find.Execute(Replace:=wdReplaceAll)
    With Selection.Find
        .Text = "ow"
        .Replacement.Text = "ö"
        .Forward = True
        .Wrap = wdFindAsk
        .Format = False
        .MatchCase = False
        .MatchWholeWord = False
        .MatchWildcards = False
        .MatchSoundsLike = False
        .MatchAllWordForms = False
    End With
    Selection.Find.Execute(Replace:=wdReplaceAll)
    'The following fixes triplicate vowels
    With Selection.Find
        .Text = "aaa"
        .Replacement.Text = "aa"
        .Forward = True
        .Wrap = wdFindAsk
        .Format = False
        .MatchCase = False
        .MatchWholeWord = False
        .MatchWildcards = False
        .MatchSoundsLike = False
        .MatchAllWordForms = False
    End With
    Selection.Find.Execute(Replace:=wdReplaceAll)
    With Selection.Find
        .Text = "iii"
        .Replacement.Text = "ii"
        .Forward = True
        .Wrap = wdFindAsk
        .Format = False
        .MatchCase = False
        .MatchWholeWord = False
        .MatchWildcards = False
        .MatchSoundsLike = False
        .MatchAllWordForms = False
    End With
    Selection.Find.Execute(Replace:=wdReplaceAll)
    With Selection.Find
        .Text = "uuu"
        .Replacement.Text = "uu"
        .Forward = True
        .Wrap = wdFindAsk
        .Format = False
        .MatchCase = False
        .MatchWholeWord = False
        .MatchWildcards = False
        .MatchSoundsLike = False
        .MatchAllWordForms = False
    End With
    Selection.Find.Execute(Replace:=wdReplaceAll)
    With Selection.Find
        .Text = "eee"
        .Replacement.Text = "ee"
        .Forward = True
        .Wrap = wdFindAsk
        .Format = False
        .MatchCase = False
        .MatchWholeWord = False
        .MatchWildcards = False
        .MatchSoundsLike = False
        .MatchAllWordForms = False
    End With
    Selection.Find.Execute(Replace:=wdReplaceAll)
    With Selection.Find
        .Text = "ooo"
        .Replacement.Text = "oo"
        .Forward = True
        .Wrap = wdFindAsk
        .Format = False
        .MatchCase = False
        .MatchWholeWord = False
        .MatchWildcards = False
        .MatchSoundsLike = False
        .MatchAllWordForms = False
    End With
    Selection.Find.Execute(Replace:=wdReplaceAll)
    With Selection.Find
        .Text = "aaä"
        .Replacement.Text = "aä"
        .Forward = True
        .Wrap = wdFindAsk
        .Format = False
        .MatchCase = False
        .MatchWholeWord = False
        .MatchWildcards = False
        .MatchSoundsLike = False
        .MatchAllWordForms = False
    End With
    Selection.Find.Execute(Replace:=wdReplaceAll)
    With Selection.Find
        .Text = "iiï"
        .Replacement.Text = "iï"
        .Forward = True
        .Wrap = wdFindAsk
        .Format = False
        .MatchCase = False
        .MatchWholeWord = False
        .MatchWildcards = False
        .MatchSoundsLike = False
        .MatchAllWordForms = False
    End With
    Selection.Find.Execute(Replace:=wdReplaceAll)
    With Selection.Find
        .Text = "uuü"
        .Replacement.Text = "uü"
        .Forward = True
        .Wrap = wdFindAsk
        .Format = False
        .MatchCase = False
        .MatchWholeWord = False
        .MatchWildcards = False
        .MatchSoundsLike = False
        .MatchAllWordForms = False
    End With
    Selection.Find.Execute(Replace:=wdReplaceAll)
    With Selection.Find
        .Text = "eeë"
        .Replacement.Text = "eë"
        .Forward = True
        .Wrap = wdFindAsk
        .Format = False
        .MatchCase = False
        .MatchWholeWord = False
        .MatchWildcards = False
        .MatchSoundsLike = False
        .MatchAllWordForms = False
    End With
    Selection.Find.Execute(Replace:=wdReplaceAll)
    With Selection.Find
        .Text = "ooö"
        .Replacement.Text = "oö"
        .Forward = True
        .Wrap = wdFindAsk
        .Format = False
        .MatchCase = False
        .MatchWholeWord = False
        .MatchWildcards = False
        .MatchSoundsLike = False
        .MatchAllWordForms = False
    End With
    Selection.Find.Execute(Replace:=wdReplaceAll)
    'The following recovers the English comments
    With Selection.Find
        .Text = "bjþ"
        .Replacement.Text = "BJT"
        .Forward = True
        .Wrap = wdFindAsk
        .Format = False
        .MatchCase = False
        .MatchWholeWord = False
        .MatchWildcards = False
        .MatchSoundsLike = False
        .MatchAllWordForms = False
    End With
    Selection.Find.Execute(Replace:=wdReplaceAll)
    With Selection.Find
        .Text = "p þ s"
        .Replacement.Text = "P T S"
        .Forward = True
        .Wrap = wdFindAsk
        .Format = False
        .MatchCase = False
        .MatchWholeWord = False
        .MatchWildcards = False
        .MatchSoundsLike = False
        .MatchAllWordForms = False
    End With
    Selection.Find.Execute(Replace:=wdReplaceAll)
    With Selection.Find
        .Text = "pþs"
        .Replacement.Text = "PTS"
        .Forward = True
        .Wrap = wdFindAsk
        .Format = False
        .MatchCase = False
        .MatchWholeWord = False
        .MatchWildcards = False
        .MatchSoundsLike = False
        .MatchAllWordForms = False
    End With
    Selection.Find.Execute(Replace:=wdReplaceAll)
    With Selection.Find
        .Text = "eðiþor"
        .Replacement.Text = "Editor"
        .Forward = True
        .Wrap = wdFindAsk
        .Format = False
        .MatchCase = False
        .MatchWholeWord = False
        .MatchWildcards = False
        .MatchSoundsLike = False
        .MatchAllWordForms = False
    End With
    Selection.Find.Execute(Replace:=wdReplaceAll)
    With Selection.Find
        .Text = " noþe:"
        .Replacement.Text = " note:"
        .Forward = True
        .Wrap = wdFindAsk
        .Format = False
        .MatchCase = False
        .MatchWholeWord = False
        .MatchWildcards = False
        .MatchSoundsLike = False
        .MatchAllWordForms = False
    End With
    Selection.Find.Execute(Replace:=wdReplaceAll)
    With Selection.Find
        .Text = "enð noþes"
        .Replacement.Text = "End Notes"
        .Forward = True
        .Wrap = wdFindAsk
        .Format = False
        .MatchCase = False
        .MatchWholeWord = False
        .MatchWildcards = False
        .MatchSoundsLike = False
        .MatchAllWordForms = False
    End With
    Selection.Find.Execute(Replace:=wdReplaceAll)
    With Selection.Find
        .Text = "cpð"
        .Replacement.Text = "CPD"
        .Forward = True
        .Wrap = wdFindAsk
        .Format = False
        .MatchCase = False
        .MatchWholeWord = False
        .MatchWildcards = False
        .MatchSoundsLike = False
        .MatchAllWordForms = False
    End With
    Selection.Find.Execute(Replace:=wdReplaceAll)
    With Selection.Find
        .Text = " vol "
        .Replacement.Text = " Vol "
        .Forward = True
        .Wrap = wdFindAsk
        .Format = False
        .MatchCase = False
        .MatchWholeWord = False
        .MatchWildcards = False
        .MatchSoundsLike = False
        .MatchAllWordForms = False
    End With
    Selection.Find.Execute(Replace:=wdReplaceAll)
    With Selection.Find
        .Text = " page "
        .Replacement.Text = " Page "
        .Forward = True
        .Wrap = wdFindAsk
        .Format = False
        .MatchCase = False
        .MatchWholeWord = False
        .MatchWildcards = False
        .MatchSoundsLike = False
        .MatchAllWordForms = False
    End With
    Selection.Find.Execute(Replace:=wdReplaceAll)
    With Selection.Find
        .Text = " vin /"
        .Replacement.Text = " Vin /"
        .Forward = True
        .Wrap = wdFindAsk
        .Format = False
        .MatchCase = False
        .MatchWholeWord = False
        .MatchWildcards = False
        .MatchSoundsLike = False
        .MatchAllWordForms = False
    End With
    Selection.Find.Execute(Replace:=wdReplaceAll)
    With Selection.Find
        .Text = " Vol ð"
        .Replacement.Text = " Vol D"
        .Forward = True
        .Wrap = wdFindAsk
        .Format = False
        .MatchCase = False
        .MatchWholeWord = False
        .MatchWildcards = False
        .MatchSoundsLike = False
        .MatchAllWordForms = False
    End With
    Selection.Find.Execute(Replace:=wdReplaceAll)
    With Selection.Find
        .Text = "\z ð "
        .Replacement.Text = "\z D "
        .Forward = True
        .Wrap = wdFindAsk
        .Format = False
        .MatchCase = False
        .MatchWholeWord = False
        .MatchWildcards = False
        .MatchSoundsLike = False
        .MatchAllWordForms = False
    End With
    Selection.Find.Execute(Replace:=wdReplaceAll)
    With Selection.Find
        .Text = "classificaþion"
        .Replacement.Text = "Classification"
        .Forward = True
        .Wrap = wdFindAsk
        .Format = False
        .MatchCase = False
        .MatchWholeWord = False
        .MatchWildcards = False
        .MatchSoundsLike = False
        .MatchAllWordForms = False
    End With
    Selection.Find.Execute(Replace:=wdReplaceAll)
    With Selection.Find
        .Text = "Vol kh "
        .Replacement.Text = "Vol Kh "
        .Forward = True
        .Wrap = wdFindAsk
        .Format = False
        .MatchCase = False
        .MatchWholeWord = False
        .MatchWildcards = False
        .MatchSoundsLike = False
        .MatchAllWordForms = False
    End With
    Selection.Find.Execute(Replace:=wdReplaceAll)
    With Selection.Find
        .Text = "khp "
        .Replacement.Text = "Khp "
        .Forward = True
        .Wrap = wdFindAsk
        .Format = False
        .MatchCase = False
        .MatchWholeWord = False
        .MatchWildcards = False
        .MatchSoundsLike = False
        .MatchAllWordForms = False
    End With
    Selection.Find.Execute(Replace:=wdReplaceAll)
    With Selection.Find
        .Text = "fooþnoþe "
        .Replacement.Text = "Footnote "
        .Forward = True
        .Wrap = wdFindAsk
        .Format = False
        .MatchCase = False
        .MatchWholeWord = False
        .MatchWildcards = False
        .MatchSoundsLike = False
        .MatchAllWordForms = False
    End With
    Selection.Find.Execute(Replace:=wdReplaceAll)
    With Selection.Find
        .Text = "f i"
        .Replacement.Text = "f I"
        .Forward = True
        .Wrap = wdFindAsk
        .Format = False
        .MatchCase = False
        .MatchWholeWord = False
        .MatchWildcards = False
        .MatchSoundsLike = False
        .MatchAllWordForms = False
    End With
    Selection.Find.Execute(Replace:=wdReplaceAll)
    With Selection.Find
        .Text = "w i"
        .Replacement.Text = "w I"
        .Forward = True
        .Wrap = wdFindAsk
        .Format = False
        .MatchCase = False
        .MatchWholeWord = False
        .MatchWildcards = False
        .MatchSoundsLike = False
        .MatchAllWordForms = False
    End With
    Selection.Find.Execute(Replace:=wdReplaceAll)
    With Selection.Find
        .Text = "["
        .Replacement.Text = "<br /><span class=""latin"">["
        .Forward = True
        .Wrap = wdFindAsk
        .Format = False
        .MatchCase = False
        .MatchWholeWord = False
        .MatchWildcards = False
        .MatchSoundsLike = False
        .MatchAllWordForms = False
    End With
    Selection.Find.Execute(Replace:=wdReplaceAll)
    With Selection.Find
        .Text = "]"
        .Replacement.Text = "]</span><br />"
        .Forward = True
        .Wrap = wdFindAsk
        .Format = False
        .MatchCase = False
        .MatchWholeWord = False
        .MatchWildcards = False
        .MatchSoundsLike = False
        .MatchAllWordForms = False
    End With
    Selection.Find.Execute(Replace:=wdReplaceAll)
    Selection.HomeKey(Unit:=wdStory)
    ' Last part:
    ' Places the HTML header and footer
    '
    Selection.HomeKey(Unit:=wdStory)
    Selection.TypeText(Text:="<!DOCTYPE HTML PUBLIC ""-//W3C//DTDHTML 4.0 Transitional//EN"">")
    Selection.TypeParagraph()
    Selection.TypeText(Text:="<html>")
    Selection.TypeParagraph()
    Selection.TypeText(Text:="<head>")
    Selection.TypeParagraph()
    Selection.TypeText(Text:="<title>RS - macro conversion from original at www.metta.lk</title>")
    Selection.TypeParagraph()
    Selection.TypeText(Text:="<meta http-equiv=""Content-Type"" content=""text/html; Charset=iso-8859-1"">")
    Selection.TypeParagraph()
    Selection.TypeText(Text:="<script type=""text/javascript"" src=""http://www.americansmartfonts.com/ds/sinhala.js"">")
    Selection.TypeParagraph()
    Selection.TypeText(Text:="</script>")
    Selection.TypeParagraph()
    Selection.TypeText(Text:="<link rel=""stylesheet"" href=""http://www.americansmartfonts.com/ds/ds.css"" type=""text/css"">")
    Selection.TypeParagraph()
    Selection.TypeText(Text:="</head>")
    Selection.TypeParagraph()
    Selection.TypeText(Text:="<body class=""sinhala"" style=""font-size: 16px;"">")
    Selection.TypeParagraph()
    Selection.EndKey(Unit:=wdStory)
    Selection.TypeParagraph()
    Selection.TypeText(Text:="</body>")
    Selection.TypeParagraph()
    Selection.TypeText(Text:="</html>")
End Sub