

# Illustrations of Unicode Sinhala and Romanized Sinhala on an Un-localized computer #
The top part in the message body is Romanized Sinhala displayed in the native Sinhala script.<br>
Sinhala seen in the Subject line and everywhere else in the message body is Unicode Sinhala<br>
<br>
<img src='http://img19.imageshack.us/img19/7234/ss20090414200653.png' />

This screen-shot of the same message shows Romanized Sinhala part in the Latin script. It is still readable.<br>
<br>
<img src='http://img19.imageshack.us/img19/8089/ss20090414200657.png' />

<hr />
<h1>Problems of Unicode Sinhala</h1>
<h2>kombuva and hal lakuna</h2>
Let's first introduce some Unicode terms. Every piece of text you read has two layers. What you see is the display layer which has the human readable letters (glyphs) picked from a font. The lower layer is called the 'text run'. It is a row of numeric codes. A code that represents a single letter directly from the Hodiya is called a 'base' letter. A 'cluster' is a set of codes that make up a complex letter like koyanna. (e.g., The code for the base letter kayanna and the code of kombuva and ælapilla pair). Unicode rules say that in a 'cluster', the code for vowels MUST follow the consonants. That is, the code for kombuva plus ælapilla MUST be placed behind the code for the base letter kayanna. The program you use to type Sinhala must have the capability to do this rearrangement in the Text Run underneath.<br>
<br>
Here is an example of typing Unicode Sinhala and the process that follows:<br>
<h3>Typing koøaBa kello (Colombo girls) using Unicode Sinhala</h3>
You type these two words using Wijesekera keyboard in the way given below:<br>
<pre><code>[kombuva, kayanna, ælapilla] [muurðhaja-layanna] [aBa-bayanna] [hidasa] [kombuva, kayanna] [layanna, hal-kiriima] [kombuva, layanna, ælapilla]<br>
</code></pre>
Underneath, the numeric codes are ordered in the following order (a square bracket set enclose each two-byte code):<br>
<pre><code>[kayanna] [kombuva+ælapilla] [muurðhaja-layanna] [aBa-bayanna] [hidasa] [kayanna] [kombuva] [layanna] [halkiriima] [layanna] [kombuva+ælapilla]<br>
</code></pre>

When you send this two-word text to another computer that computer must have the Sinhala script rendering rules installed in it to show Sinhala properly. That does not come with the computer when you by it. You need to download it and install it from ICTA. That process is called LOCALIZING. Localizing converts many areas of the computer into Sinhala. You cannot do that to your boss's computer in America. In that case, you will see the letters in the order that the text run brings you. The result is kombuva always follows the akura and hal kiriima is always the flag shaped one.<br>
<br>
<h2>Wijesekera keyboard and Localizing</h2>
You must have the Wijesekera keyboard to type Unicode Sinhala. You MUST localize the computer for this.<br>
<br>
<h2>Collation and Text Processing</h2>
Now think of collation (putting words in alphabetic order). All text operations are performed on Unicode characters. kombuva and ælapilla pair is one Unicode character. (The bracketed items in the text run example above are single Unicode characters.<br>
See: <a href='http://www.unicode.org/charts/PDF/U0D80.pdf'>http://www.unicode.org/charts/PDF/U0D80.pdf</a>

The vowels and vowel signs have their own specific codes. If you are going to write a hodiya collation you'd have to reconstruct 38 <b>(18+12+10)=1520 weighted clusters. The two conjoint characters aka canonical forms (U-0DA1 and U-0DA5) need to be decomposed ahead of comparison. (0DA1 = çj; 0DA5 = jç).</b>

You'll have to have a special routine written to equate the free-standing vowels (e.g. eyanna) and their signs ( kombuva) and to decompose kayanna etc. to hal-kayanna and ayanna etc. for 38 letters.<br>
<br>
No commercially available word processor will ever have these routines written and added.<br>
<br>
<h2>Pali and Sanskrit</h2>
Pali and Sanskrit treat ç and j as individual letters in their Latin transcriptions. Conversion between Pali / Sanskrit texts and Unicode Sinhala would be another programming challenge that the Sri Lankans would pass over.<br>
<br>
<h2>SBCS vs DBCS</h2>
SBCS means Single-Byte Code Space. Every commercially available time-tested business application is made for SBCS. DBCS means Double-Byte Code Space. it does not have general purpose applications written for it.<br>
<br>
<h2>Conclusion</h2>
The above facts make Unicode Sinhala crippled. The elite could care less because they use English. Poor Sinhalese people would be restricted to using Sinhala to write documents, read web pages. No text processing or higher uses like using them in commercial programs would be possible.<br>
<br>
<hr />
<h1>Romanized Sinhala</h1>
<h2>What might be the better standard for Sinhala on computers</h2>

Notice how Unicode Sinhala appears in both messages in the above screen-shots (text after the signature). It is extremely hard to read because the kombuva is consistently misplaced, often hal kiriima is misplaced and worse, hal kiriima is shaped wrong too.<br>
<br>
However, Unicode Sinhala is commonly believed as the only legitimate method for Sinhala on computers. This is a misconception. If any scheme for a language is standards compliant, it is a legitimate scheme. Dual-script Sinhala is fully compliant of Unicode as well as World Wide Web (<a href='http://w3.org'>http://w3.org</a>) technologies. So far, the <b>only</b> Sinhala web site that is fully HTML compliant is the <a href='http://www.LovataSinhala.com'>http://www.LovataSinhala.com</a> web site. It uses Romanized Sinhala also called Dual-script Sinhala.<br>
<br>
Unicode Sinhala becomes degraded in a computer that does not have Sinhala package installed in it. Something that most people living in Sri Lanka do not realize is that for various reasons, people living overseas are not able to Localize their computers to Sinhala. Often they use their office computers to read email. It is virtually impossible to read Unicode Sinhala on them. Often computers show only rectangles in place of Sinhala letters. (Please see the blue Title Bar of the screen-shots. Unicode appears as square brackets).<br>
<br>
Unicode Consortium understands these problems. As such, in 2008, Unicode Consortium started to advocate creation of Latin-1 (Single-byte) transliteration schemes for languages like Sinhala. Unicode Sinhala is a double-byte scheme. The main motivation behind this change of heart at Unicode is the inability to use double-byte scripts on regular applications. They say that if the languages had Latin transliterations, then they could use regular off-the-shelf programs. Romanized Sinhala is a transliteration scheme for Sinhala that meets and exceeds these needs.<br>
<br>
<h2>A method that never reduces to garbage</h2>

SVG standard established by World Wide Web (W3C.org) in 2003 makes it possible to show romanized Sinhala in Sinhala letters simply using a font. It is in the HTML 5.0 standard. That obviates the need to translate between dual-byte and single-byte schemes as the purpose of Unicode Sinhala is to show Sinhala in the native script.<br>
<br>
Mozilla (makers of the Firefox browser and Thunderbird email client) already supports SVG. Internet Explorer is still behind. The beta version of Thunderbird for email allows writing of email using Sinhala smartfonts that show Romanized Sinhala in the native Sinhala script. When SVG becomes available in all browsers, Sinhala would be like English or German in all respects, but superior in that Sinhala is dual-scripted