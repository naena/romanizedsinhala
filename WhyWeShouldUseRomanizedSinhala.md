

With the release of Firefox 3 browser and upcoming release of Thunderbird 3 email client, we are able to publish Sinhala on web pages and use it in email messages just like English.

While Microsoft and Open Office are dragging their feet, we can still use a not-so-upscale wordprocessor for Sinhala, WorldPad, available as a free download at SIL.org. You can mix Sinhala with English in it, make the letters slanted, change font size, color etc.

Click [GettingStarted](GettingStarted.md) to quit talk for a quick start.

# Why we should use dual-script Sinhala #
Both Unicode Sinhala and the Sinhala web fonts are not digital solutions for the successful use of Sinhala on the computer because the bases of their designs are flawed.

# Unicode Sinhala #
Unicode Sinhala standard was proposed by [Michael Everson](http://www.evertype.com/), a font maker. [Earlier draft](http://unicode.org/Public//TEXT/UTR-2.TXT) was by Andy Daniels, an American Unicode enthusiast. Michael followed the standards of Indian languages, (as it appears) consulted German sources and drafted the Sinhala code block certifying it as correct. He obtained endorsements by two Lankans too.

Unfortunately, he did not (nor should we have expected him to) understand inextricable associations Sinhala script has with Pali and Sanskrit and the intricacies of its multiple orthographies that seems like unique in Sinhala. Well, it is much a grander language than what we were led to believe.

# False start #
At Unicode, the digital solution for Indic, including Sinhala and Tamil seems to have conceived as a system to digitize the visible text. It is difficult to know what depth the vyaakaraµa (grammar) was taken into consideration. It is curious why signs of vowels that Sinhalese call pili are called matra in Unicode and the OpenType standards. In Sanskrit and Sinhala grammar there is the indispensable term maaþra that corresponds to mora in linguistics which stands for the length of an uttered sound. Unlike in the West, phonology is fundamental and integral in Indic grammar. As far as we see, especially after studying Unicode and Opentype standards, both the standards have seriously strayed due to the typewriter-to-computer approach and ignorance of Sanskrit grammar and stipulations on akxara.

# Unfamiliar territory #
We believe that Lanka was severely 'digitally challenged' at the time Unicode Sinhala was defined. It was indeed unfair to ask to accept something that related to some technology that was not familiar to many in the world. Americans, who are the early adopters of technology too were as bad in early 1990s with computers.

Another factor certainly was the psychological effect of the orchestration in the West that Indic alphabets are 'Abugida' type 'complex' alphabets impossible to be fully ported to the computer because of a strange phenomenon called Virama. Perhaps both these and our dependence on 'big brother' India to go first in these matters led Lanka go with the flow. In any case, Unicode was bent on its plan for Indic with threatened deadlines, and the Indic users only had to test and help Microsoft to finish Uniscribe font rendering machine. (This is tedious and still going on).

We should recall that ISO had better, more equitable plans for non-European languages in 1992 before the 'merger' with Unicode. There is nobody to blame except that we are left with a unsatisfactory result, a result that certainly looks like a serendipitous happening of a consuming locality in the wider globalization effort of international business.

# A solution or a burden? #
Unicode Sinhala is in the Double-byte Code Space (DBCS). It requires extra-ordinary special treatment when it is entered into the computer, when it is transmitted over the network or when it is displayed. Data entry requires a special keyboard fashioned after the Wijesekera typewriter keyboard, much different from the familiar QWERTY keyboard, an entirely new thing to learn. It appears as if that the decision makers envisaged 'typists' typing Sinhala for them at the computer. In fairness, this is not too different from the perception American businessmen had in the pre-Internet era.

In addition to the base letters (hodi akuru), Unicode Sinhala has unique codes assigned to vowel marks (pili). That makes each vowel to have two Unicode positions, one for the stand-alone letter and another when it has joined with a consonant. For instance, oyanna is at 0D94, and its kombuva haa ælapilla combination is at 0DDC. Unicode forces a consonant plus vowel combination once typed to be crystallized into an indivisible entity. The result is that the constituent parts of such a construct cannot be reached in text processing -- a crippling handicap.

Unicode Sinhala block has two letters at positions 0DA5 and 0DA6 that are actually conjoint letters. This is a violation of Unicode's normalizing rules. Tragically, these were defined even after the [normalizing rules](http://unicode.org/reports/tr15/) were established. These two problems alone make Sinhala Unicode incapacitated as a digital solution for Sinhala. It only makes the computer the new typewriter.

Each Unicode Sinhala letter uses a code consisting of two bytes, and when it is transmitted, it needs to be encoded into a special format, [UTF-8](http://www.faqs.org/rfcs/rfc2279.html) that makes it three bytes!

When the decoded DBCS letter is displayed, it degenerates into question marks or rectangles if the host computer does not have the font carrying Unicode letters or if it does not support Double-byte characters. If the host system has a font such as updated Arial Unicode by Microsoft for "Plain Text" display, the correct ordering of akuru and pili further requires installation of the special Unicode Sinhala package.

# Web fonts #
Because of these problems, a new generation of "8-bit" fonts came into existence following Kaputadotcom font. These fonts reshape the positions of Latin letters into Sinhala akuru. They have an entire range of font face designs in response to the demands of web and print industries. Unfortunately, they borrow marks in the QWERTY keyboard such as '@, #, $, ^, &,`*`, _, |' etc. for additional akuru and pili violating the Unicode standard. More significantly, since they do not have their own 'font-family' standard, if the specified font is missing it falls back to the default font in the system resulting in digital garbage._

If you write the Sinhala translation of the phrase "Sinhala letters" using Unicode Sinhala, the host computer that does not have Unicode Sinhala set up in it would show the phrase as, ????? ????? or a row of rectangles. The same phrase typed using Kaputadotcom web font would appear as "sQAhl akOr#" on a computer that lacks that font.

# Dual-script Sinhala #
The solution that we developed is based on **romanized Sinhala** and employs **orthographic fonts** (smartfonts) to dynamically display the underlying Latin base in the Sinhala script. Instantly, it is Unicode compliant. If the above test were to be applied to it, and if the host computer lacks the specified Sinhala smartfont, that phrase would fall back to "síhala akuru" in the system font, exactly the way it was typed. This goes to illustrate that romanized Sinhala is universally available on all computers, without regard to the presence or absence of the Sinhala font, the type of Operating System or the geographical location of the host computer. In other words, if you have the smartfont and your correspondent doesn't have it, they still can read a message you sent in romanized Sinhala. This is why we call it Dual-script (DS) Sinhala.

DS Sinhala is radically simple to use on the computer. It is entirely contained within the ISO-8859-1 code set, which is the SBCS (Single-byte Character Set). It combines Sanskrit, Sinhala and Pali without compromising the three hodi (varµa sákhyaa / akxara maalaa). (NOTE: A hodiya is not same as an alphabet). Every Latin character used in romanized Sinhala is available in all general purpose digital fonts. The same solution is available for Tamil as well, which means a document could be typed straight through in all three languages all in the Latin script or each part of a language formatted with its own font of native script.

# Romanized Sinhala keyboard layout #
DS Sinhala is entered using the familiar QWERTY keyboard extended to include additional international characters. Linux, Windows and Macintosh each come with a keyboard layout that supports this extension, and are widely used in Europe. The key positioning is intuitive and the same extended keyboard layout could be used to type Sinhala and English (plus Tamil in the future) allowing typing speeds such as 100 wpm required for courtroom transcription.

# Orthographic smartfonts #
Our test smartfonts are only proof-of-concept products and are not complete or conform to specific orthographies. We have nearly finished analyzing the orthographies but due to time constraints are not ready to issue commercial grade, typographically designed smart fonts. However, our Suriyakumara smartfont already beats Unicode Sinhala in its ability to display complex Sanskrit orthographic constructs and Theodore, our first test font, perfectly displays Pali Tripitaka pages in the Sinhala script. The font is best used using IRA Iriyagolla Standard Sinhala. It can even identify certain classes of illegal constructs and flags them as unacceptable.

We believe dual-script solution would remove the digital divide between the urban and the country populations opening the door for the Sinhala-only/Tamil-only youth to participate meaningfully in the brave new world of digital technology. That is paramount in this digital age. Many other countries that use languages other than English particularly engage in the open-source projects using their limited English but showing their shining innovations. Imagine where we could go with our 92% literacy rate equal to that of developed nations. DBCS Sinhala is ill-equipped for this type of application.

# The proof is in the eating #
As they say, 'Proof of the pudding is in the eating'. Therefore, we challenge you to first go to this page: [GettingStarted](GettingStarted.md) do as suggested to test DS Sinhala. Your computer should be one of the following:

  * Linux OS
  * Windows 2000 or later
  * Macintosh OS X 10.4 or later


Thank you again.
```
JC Ahangama
jc@LANandWAN.com
American Smart Fonts
817-222-0963
```

2008-06-23