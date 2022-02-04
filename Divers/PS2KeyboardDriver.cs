 
 namespace​ ​ThreeOS.Driver 
 ​{ 
 ​    ​public​ ​static​ ​class​ ​PS2Keyboard 
 ​    { 
 ​        ​public​ ​static​ ​char​ ​Key​; 
  
 ​        ​public​ ​static​ ​char​ ​ProcessKey​(​byte​ ​b​) 
 ​        { 
 ​            ​switch​ (​b​) 
 ​            { 
 ​ 
 ​                ​case​ ​0x​1E​: ​return​ ​'A'​; 
 ​                ​case​ ​0x​30​: ​return​ ​'B'​; 
 ​                ​case​ ​0x​2E​: ​return​ ​'C'​; 
 ​                ​case​ ​0x​20​: ​return​ ​'D'​; 
 ​                ​case​ ​0x​12​: ​return​ ​'E'​; 
 ​                ​case​ ​0x​21​: ​return​ ​'F'​; 
 ​                ​case​ ​0x​22​: ​return​ ​'G'​; 
 ​                ​case​ ​0x​23​: ​return​ ​'H'​; 
 ​                ​case​ ​0x​17​: ​return​ ​'I'​; 
 ​                ​case​ ​0x​24​: ​return​ ​'J'​; 
 ​                ​case​ ​0x​25​: ​return​ ​'K'​; 
 ​                ​case​ ​0x​26​: ​return​ ​'L'​; 
 ​                ​case​ ​0x​32​: ​return​ ​'M'​; 
 ​                ​case​ ​0x​31​: ​return​ ​'N'​; 
 ​                ​case​ ​0x​18​: ​return​ ​'O'​; 
 ​                ​case​ ​0x​19​: ​return​ ​'P'​; 
 ​                ​case​ ​0x​10​: ​return​ ​'Q'​; 
 ​                ​case​ ​0x​13​: ​return​ ​'R'​; 
 ​                ​case​ ​0x​1F​: ​return​ ​'S'​; 
 ​                ​case​ ​0x​14​: ​return​ ​'T'​; 
 ​                ​case​ ​0x​16​: ​return​ ​'U'​; 
 ​                ​case​ ​0x​2F​: ​return​ ​'V'​; 
 ​                ​case​ ​0x​11​: ​return​ ​'W'​; 
 ​                ​case​ ​0x​2D​: ​return​ ​'X'​; 
 ​                ​case​ ​0x​15​: ​return​ ​'Y'​; 
 ​                ​case​ ​0x​2C​: ​return​ ​'Z'​; 
  
 ​                ​//​Key Up 
 ​                ​case​ ​0x​80​ ​+​ ​0x​1E​: ​return​ ​'a'​; 
 ​                ​case​ ​0x​80​ ​+​ ​0x​30​: ​return​ ​'b'​; 
 ​                ​case​ ​0x​80​ ​+​ ​0x​2E​: ​return​ ​'c'​; 
 ​                ​case​ ​0x​80​ ​+​ ​0x​20​: ​return​ ​'d'​; 
 ​                ​case​ ​0x​80​ ​+​ ​0x​12​: ​return​ ​'e'​; 
 ​                ​case​ ​0x​80​ ​+​ ​0x​21​: ​return​ ​'f'​; 
 ​                ​case​ ​0x​80​ ​+​ ​0x​22​: ​return​ ​'g'​; 
 ​                ​case​ ​0x​80​ ​+​ ​0x​23​: ​return​ ​'h'​; 
 ​                ​case​ ​0x​80​ ​+​ ​0x​17​: ​return​ ​'i'​; 
 ​                ​case​ ​0x​80​ ​+​ ​0x​24​: ​return​ ​'j'​; 
 ​                ​case​ ​0x​80​ ​+​ ​0x​25​: ​return​ ​'k'​; 
 ​                ​case​ ​0x​80​ ​+​ ​0x​26​: ​return​ ​'l'​; 
 ​                ​case​ ​0x​80​ ​+​ ​0x​32​: ​return​ ​'m'​; 
 ​                ​case​ ​0x​80​ ​+​ ​0x​31​: ​return​ ​'n'​; 
 ​                ​case​ ​0x​80​ ​+​ ​0x​18​: ​return​ ​'o'​; 
 ​                ​case​ ​0x​80​ ​+​ ​0x​19​: ​return​ ​'p'​; 
 ​                ​case​ ​0x​80​ ​+​ ​0x​10​: ​return​ ​'q'​; 
 ​                ​case​ ​0x​80​ ​+​ ​0x​13​: ​return​ ​'r'​; 
 ​                ​case​ ​0x​80​ ​+​ ​0x​1F​: ​return​ ​'s'​; 
 ​                ​case​ ​0x​80​ ​+​ ​0x​14​: ​return​ ​'t'​; 
 ​                ​case​ ​0x​80​ ​+​ ​0x​16​: ​return​ ​'u'​; 
 ​                ​case​ ​0x​80​ ​+​ ​0x​2F​: ​return​ ​'v'​; 
 ​                ​case​ ​0x​80​ ​+​ ​0x​11​: ​return​ ​'w'​; 
 ​                ​case​ ​0x​80​ ​+​ ​0x​2D​: ​return​ ​'x'​; 
 ​                ​case​ ​0x​80​ ​+​ ​0x​15​: ​return​ ​'y'​; 
 ​                ​case​ ​0x​80​ ​+​ ​0x​2C​: ​return​ ​'z'​; 
  
 ​                ​case​ ​0x​02​: ​return​ ​'1'​; 
 ​                ​case​ ​0x​03​: ​return​ ​'2'​; 
 ​                ​case​ ​0x​04​: ​return​ ​'3'​; 
 ​                ​case​ ​0x​05​: ​return​ ​'4'​; 
 ​                ​case​ ​0x​06​: ​return​ ​'5'​; 
 ​                ​case​ ​0x​07​: ​return​ ​'6'​; 
 ​                ​case​ ​0x​08​: ​return​ ​'7'​; 
 ​                ​case​ ​0x​09​: ​return​ ​'8'​; 
 ​                ​case​ ​0x​0A​: ​return​ ​'9'​; 
 ​                ​case​ ​0x​0B​: ​return​ ​'0'​; 
 ​                ​case​ ​0x​39​: ​return​ ​' '​; 
 ​                ​case​ ​0x​1C​: ​return​ ​'​\n​'​; 
 ​                ​case​ ​0x​0E​: ​return​ ​'​\b​'​; 
 ​                ​default​: ​return​ ​'?'​; 
 ​            } 
 ​        } 
 ​    } 
 ​}
