
# UTF-8 and Latin-1: The Leaning Tower of Babel #
**Original article:**  from http://techessence.info/node/60

Dorothea Salo has already written an introduction to Unicode with some mention of UTF-8, but let me do a little venting here. There’s some dense technical detail here (or maybe I’m the one who’s being dense); the “so what?” part is at the end.

If you’re dealing with 8-bit bytes and 1-byte characters--and that has been pretty much universal in computers for decades--you have a total of 256 characters to play with. That isn’t nearly enough if you want to be display all the world’s alphabets and writing systems. It isn’t even enough if you want to display all the variations on the Roman alphabet. So you either need to select a subset of characters to work with, or use more bytes to refer to characters.

To begin at the beginning: US-ASCII is a system that uses 7 bits to assign characters to 128 numbered slots (that’s 27 of course - ASCII-only systems sometimes used the eighth bit for error checking, and modern systems just set it to zero). ASCII has been entrenched in computing for so long that subsequent methods for encoding characters face immense pressure to remain backward compatible with it. Unfortunately, ASCII only has space for some control characters (carriage return, new line, new page, etc.), and the characters and punctuation used in U.S. English, plus some punctuation commonly used in programming.

You can double the number of available slots for characters if you use that eighth bit, giving you the full 256. (Well, 224 - thanks to differences between proprietary systems, slots 128 through 159 can’t be reliably agreed on, and so those slots are left out of standards for character encoding.) The ISO 8859 standard uses slots 160 through 255 over and over with different meanings; these are character sets Latin-1, Latin-2, etc. This lets you refer to almost all the characters in languages using the Roman alphabet, plus Greek, Cyrillic, Hebrew, Arabic, and Thai characters. But not all at the same time. You couldn’t, for example, write about Stanisław Lem and Françoise Sagan taking a summer house in the Turkish town of Köyceğiz, because “ł”, “ç”, and “&#287”; are all in different character sets.

When configured to use English, Microsoft Windows uses the Latin-1 character set, plus its proprietary assignments for characters 128 through 159. This gives very widespread support to Latin-1, often making it the assumed default for 8-bit characters.

The solution to this problem is to have a single set of numbered slots with enough spaces for every character anyone would want to write down, anywhere in the world. This is essentially what Unicode is: several million slots, currently with a little under 100,000 of them assigned to characters; the first 128 characters are the same as the 128 ASCII characters and the first 128 characters in the ISO 8859 encodings.

But you can still only identify 256 characters with an 8-bit byte, so you either need to use several bytes for each character (losing ASCII compatibility and doubling or quadrupling the size of every file), or use a variable number of bytes depending on the character involved. That’s what the UTF-8 character encoding scheme does.

For slots 0 through 127, UTF-8 is identical with US-ASCII. So both Latin-1 and UTF-8 are backward compatible with ASCII.

For slots 128 through 159, neither UTF-8 nor Latin-1 define any characters.

For slots 160 through 255, UTF-8 uses that number to determine how many following bytes to add in when calculating the numbered Unicode slot being referred to; depending on the initial byte’s value, the next one, two, or three bytes are included in determining the Unicode character involved. Which means that UTF-8 requires all supporting code and applications to break the “one byte = one character” assumption and UTF-8 is not compatible with Latin-1.

Which brings me back to the Turkish town of Köyceğiz. I’m looking at a journal article titled “Mineral equilibria and geothermometry of the Dalaman–Köyceğiz thermal springs, southern Turkey,&rdquo, by Ali Gökgöz and Gültekin Tarcan (Applied Geochemistry v. 21, no. 2, p. 253-268, doi:10.1016/j.apgeochem.2005.08.010).

Except, unfortunately, that’s nothing like what I actually see onscreen. Our journal system’s display includes “…of the DalamanÃ¢ÂÂKÃÂ¶yceÃÂiz thermal springs…” and gives the authors as Ali GÃ¶kgÃ¶z and GÃ¼ltekin Tarcan.

The problem, if my diagnosis is anywhere close, is that we have multibyte UTF-8 characters being passed through code that treats them as single byte characters (probably Latin-1), and then being passed through code that converts each of those into multibyte UTF-8 characters. Repeat a few times and the result is gibberish.

So what’s the point, aside from me being hip deep in malformatted e-journal displays? Many of us work with text documents and databases that have a serious need for internationalization, starting with an unambiguous way of representing characters from outside, say, English and Western European Germanic and Romance languages. Unicode is a wonderful solution for numbering all those characters, and UTF-8 is a wonderful solution for squeezing pointers to all those numbers into a system that remains ASCII-compatible. It works very well in a vertical, integrated environment where you can guarantee that UTF-8 is correctly handled every step of the way.

But when you start passing data from one system, or vendor, or version of Perl, to another, you find support is still hit or miss. The “one byte = one character” relationship is deeply rooted in many languages and operating systems, and the “let’s just use the Windows defaults” decision is deeply rooted in many organizations. As in our system, the result can be pretty ugly.

On top of that, we have two popular but incompatible character encodings (Latin-1 and UTF-8) in common use, and the best designed systems could be excused for getting them mixed up if they aren’t explicitly told which one to use. Interoperability requires continual communication among the components to keep everyone on the same page.

At least on the web, it’s easy to avoid this ambiguity, because there are three ways to avoid confusion over what character encoding you’re using. The first is to configure the server to announce up front what encoding is in use, through the HTTP Content-type header (instead of sending “Content-type: text/html”, for example, send “Content-type: text/html; charset=UTF-8”). That requires access either to the server or the server-side script that generates the page; for HTML documents, an alternative is to write the same header into a meta tag:
```
<meta http-equiv="Content-type" content="text/html; charset=ISO-8859-1">
```
A third alternative for HTML is probably the most common: stick to ASCII, which is supported in all common encodings, and use named or numeric character entities for all non-ASCII characters: “Fran&ccedil;oise and Stanisław”.

Gee, interoperability is still tricky. Plus ça change. Or, plus Ã§a change. ☺