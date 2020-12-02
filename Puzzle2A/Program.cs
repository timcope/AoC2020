﻿using System;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace Puzzle2B
{
    class Program
    {
        private const string Input = @"
1-13 r: gqdrspndrpsrjfjx
5-16 j: jjjjkjjzjjjjjfjzjjj
14-16 r: rrrnrrrrrcnrgxrr
1-3 k: bkktwhgktv
3-5 q: dxqqqzmqvs
11-14 s: sssssssssssssv
1-3 d: cdzdq
13-16 q: scdqpdgpkvbwwqbv
9-10 d: ddrdddlddd
15-17 v: jvvvvvvgcvvvvrcvnv
2-3 s: xssx
8-15 j: jwjjjjkhjjjltjmjjjr
7-15 m: wqspfmtpjftmplwp
1-11 s: swdgzhgsxtssndzfm
3-4 b: bgjrg
1-12 x: jxgxxxpjwpsht
5-15 x: xxjxwshpxjxxxxsnxvz
4-11 r: bjnrpswfprrng
12-14 j: wjjzmwnmmvzsjhnnkj
3-4 d: dddv
2-4 b: bfxx
15-16 r: rrrrrrrrrrrlrrphrr
6-11 j: jsljjjjjjjj
6-7 m: mpttcmmmmng
6-7 g: gsggggg
2-10 b: nbtbqbbfpb
4-6 h: hhqhrzkcrhh
13-14 b: bbbbbbbbbbnbbbb
5-6 g: gggggg
5-6 x: rsxvxx
3-6 q: wxqzqqqtzsq
1-2 h: sjhj
6-18 t: jtptcwtbfgffpkdwthbf
5-9 w: wwwwcwwww
15-16 g: wqdwztbmrqdmgmvc
8-15 t: ttttgztvtttnttb
9-11 r: rrvrrrrnhrzr
8-9 l: lllllllqwl
10-11 h: hhhhhhhhhhd
3-5 g: gggrwqc
5-12 f: ffcdxfglcffsf
6-7 f: fffffzk
3-5 b: btbbbb
2-8 z: wblnvfzzwzzbchx
13-14 r: rrrrrfrrrrrrlf
2-9 r: wgbmfvksl
5-12 m: xrmmfhmqdhmmvhvrzmwq
3-4 j: jwpd
6-8 v: mvfwgskpxgvcsr
1-3 c: ctpr
2-8 d: dzdfsddd
10-14 c: ccccczcccccqlchvclcc
2-8 s: sscwcfssssssdt
2-11 l: xlsslrlclfls
7-8 r: rrrjrrrrtdcr
7-9 z: zzzzzzzpzz
12-14 r: rrrrrrrrrrrprrr
13-14 g: hdczwngvjtgmhn
1-7 q: qqdqqqqvq
5-6 q: qqqqql
11-16 p: wgwrzltpskwgxprm
4-12 d: dvddddddwddz
15-16 q: qqqqqqqqqqqqqqqqq
1-5 m: mmrjmmqsjkm
13-14 m: mlmxmmmdmgmmmw
4-5 q: qcqvmhqdq
2-3 m: brdzbfzj
3-4 s: snshj
5-9 k: kzpkkbkvqjktrk
12-13 t: fltttttttjtpstttt
7-8 c: kcccfccccxtcc
2-6 q: nnjqqd
2-9 n: msnvnrxgldqnxnngsn
2-4 c: scccwp
12-13 c: ccbccqdcccfcvdccc
6-7 f: fmdffffxcbbpffl
2-6 r: rbrrrvr
7-10 j: jzjtjjqfvjj
3-7 j: jjrjjjjj
2-13 m: mmmlmqddkmtmmm
19-20 l: drpwllkdlsjslmllsdrv
3-5 v: vxmrwwvh
5-13 z: zzzzkzzzzzzzkzzzf
5-6 g: gggggfg
4-6 c: crfvlc
14-18 x: xxxxxxxxxjxxxzxdqc
4-7 p: plzqjtp
2-4 v: nmdbhftxvbv
5-8 s: knfcsbbsxssssxd
2-13 p: mpwpnbrnlxmqvfbltcq
7-11 v: vbvvvkfvvvg
14-17 x: xxrxxxbxxwmhxxpxqxv
5-7 f: qffndfmqfsrv
7-8 v: vvvqvvbvv
9-10 j: jjjdjjjslljjjjjch
4-6 l: lllplgr
3-4 n: nnqn
4-5 c: ccccc
1-2 q: lwhqw
6-7 d: dddmddqd
6-7 g: gggggzxg
2-10 j: jsjjjjjjjsjj
13-15 b: dxbbbbbbbbbbbmbbbmbl
5-10 q: qqqqwqqqqxq
12-13 j: jjjjjzjjjjbjxjjb
5-10 t: ttfttphtttttmthttp
3-4 t: tttj
7-8 n: nnknnpphfwnn
9-10 x: xxxxxxxxcx
14-17 h: hhkhhzxhhhhhhjhhxhh
4-5 w: whxtwwftw
10-12 q: xqgqsqqvqqlqqqdqpqrq
1-3 l: jsvlzrm
8-16 z: sbzzqzxzzzskzzxgrzcz
7-10 k: kkkkjklkkt
9-11 f: ffffwfffwflnwf
1-8 c: cmccwcqzzhxccr
6-9 h: vnfxddhrhbdqkqr
8-9 t: tzttdtttvvtb
6-9 q: qqqqqqqqqqqqq
15-17 k: kkkkkkkkkkkkkklkqk
3-10 p: pprppppppfp
5-11 d: nhgkdjgvmdddt
7-9 d: rdddddddpd
1-3 r: rrwrr
5-16 t: gttwtrqqmwwljhfn
6-9 q: qqqswdzllqqf
7-13 b: mxpxbjgvsncqwv
7-8 d: dddddrddds
3-4 z: zzqzz
10-18 z: zzzqzzzzbzzwzzpzzzz
8-9 p: pppppppppp
13-16 f: fffffffffffffxtf
8-9 w: fwgwwwlsfpww
4-5 g: grgmcpdqggwckq
16-17 g: gggggwgggggggggln
3-13 j: jjmjjjjjjjjjbjjjjjj
9-13 x: xxxxxxxxxxxxx
5-12 b: bbrmbhbbsgbbbpbbz
14-18 z: zzzszzszzzzzzzzzzzh
1-13 k: pkkkkkhgfkfbtkkpkf
3-14 v: vvvpdlvvvvdfvvjvvsv
12-13 m: mmmmrmbmmmmmmrmmm
12-14 v: vvvvvvvvvcrlvkvv
18-19 p: mxpppgpwcphkzppktppk
4-10 x: xxxxxxxxxxxxx
4-5 k: kklkkk
11-13 m: mmmvmmwmzwmmmnvgmm
7-11 p: qdppjspwtcpppp
4-8 l: lllllllll
12-16 j: jjvjtjjsstfjjnjjk
15-17 h: phhhhhhhhhhrhhhhh
4-7 j: sqfjjjj
3-20 m: wzmqhwmjmclzmmmdlzqm
8-13 m: jpmmbmtgmnprgt
8-13 h: hhhhjjhchhbhqshh
15-20 b: mbbbgbbzmkbbkbbpffqb
2-3 t: tdlt
10-16 l: llllkgllrnllllll
2-4 p: phpf
3-5 d: ddddd
5-6 h: hhhhhhh
2-3 j: cjjrj
7-10 g: hgwtggfgbcpgd
3-4 d: dddk
4-6 t: mltdtf
8-9 h: zhljxshhh
2-3 p: vqjgbsp
6-7 x: gcxvjxp
15-17 s: sswgssdsgssjlssss
1-3 m: qvswmm
1-7 v: svbrvsjv
3-5 j: vjhjdq
15-16 b: bbbnbbbmbbbbbbbdbbmb
6-19 k: spkgcpkhlkkthkgkfzkj
1-2 c: dxqxnrrlfnnc
7-11 j: qjjjjjkdrjjjjj
5-11 g: ztdgvvgwhrlgnq
3-4 c: fcmqglp
4-5 q: qqqqqqq
6-7 c: cccccrc
7-11 n: nnnnbnnnnnn
9-13 x: xxxxxbdtqxdwxsx
9-15 j: ljjjjjjjjjjjjjz
2-11 j: pjjhzmtwlgjwpkjjdwq
5-6 k: kkkkkk
12-13 q: qqqqqqqqqqqmg
3-14 j: nwkjjlbbrnqvqm
3-4 h: hhhhshhhhhhmrh
2-4 l: djkxl
1-9 t: tttttfttl
9-10 g: ckggggtggggggv
3-12 l: cqlclvwhpxwlnzzsqgs
8-14 d: ddddddddnddfdh
1-5 v: vvvvxm
2-5 q: mqqqqlqk
3-4 j: tkjpj
13-16 w: wwwwwwwwwwwwwwxww
13-18 m: mmmmmmmmmmmmmzmmmmm
2-4 x: xxfxx
1-2 d: ddvddddkdddd
3-5 c: cctdc
2-10 q: tqjkqqpsctx
2-18 n: nlnnhnxnnnnnnnnnnln
3-7 k: rkkkbkk
3-4 n: ngnn
3-11 d: dqdbwtbghbdj
3-5 q: fqqqq
5-10 x: xxxxfgxxjbxbhxx
5-6 m: mmtmcn
4-6 x: xxxkxk
17-19 b: bbbbbbbbbbbbbmbbbjbb
5-6 k: kkkkhk
10-12 k: kkkkkkkkkpkgk
3-4 z: zzzz
18-19 p: plcppppksppcnptppvmp
3-6 t: tdtrltmn
3-4 q: qqqq
10-19 v: vvzrvvvvvvvvvvvvvvhv
11-16 d: kjdtddddkdvcdddpd
12-16 l: lllllllllllllllll
4-10 b: dbvbqfqlrb
10-11 k: kbkvkhlkqrv
1-9 x: sbqnkxdmxpc
5-10 l: ldlllkllrln
9-13 j: bpjjjjjjjkjzjnj
11-12 j: jjjjjjjjdjjj
2-8 l: jllzbhjlqlwcltllq
4-5 s: gsssd
2-4 s: kswn
1-18 p: bpppppppppppppppptp
9-11 v: vhvvvvvvvvvv
2-5 v: vvkvvv
8-11 p: plplqpjhdzlfpppppl
11-18 g: ggggglgvgcgggggggg
9-11 r: rrrrwrrrmrzp
3-12 g: tggggmggwnpzvgpnp
13-17 t: tnvvttxttttvtftptgt
5-16 c: cccqccccjvcccccccczc
2-4 f: tfbfrjftf
2-4 s: ssssx
3-9 v: vvspvvvjv
3-4 h: hhxh
15-17 l: lllllllllqllmlvwblll
4-9 j: rjljjjjfjjskdkwttbjt
9-10 m: jmmmmmvmhh
1-8 w: wwwlcwgwwwp
1-8 j: mllsjncl
3-4 b: tfbkbssb
1-7 g: qvdbrjkdgggb
1-3 l: wlbll
4-6 v: jvzqbvvvg
2-3 w: vjlwx
10-12 c: ccvcccrccjfhgccdw
10-18 b: bbtbbbbbggbbbbbbbvb
8-9 j: jjjjjjjjjpjg
5-15 c: ccbccccccccccvccc
16-17 t: ttttgtttttttttttthtx
13-15 t: tvsmjtjttktztrt
9-12 c: jzrpnzdncldmxqjmvccb
6-7 v: jjdvpdhv
4-5 c: ccccccccccccc
6-7 t: ttzttttt
10-11 q: qgxqqqqqqqqqq
14-15 h: hhhhhhhhhhhhhhh
3-8 b: bbbbmbbbbb
11-12 r: rhlrsrrrrjrr
2-6 v: vrvvvhv
4-5 n: nnnhn
3-5 p: pqhmnjp
7-13 h: qhhcwhhhhqhhfq
10-11 d: dddddddddxh
10-11 d: gdcdcdddcddtddsddd
1-5 f: bffspf
5-8 s: skssblsg
8-11 m: mmmcmmmwmzmmmvm
6-8 q: kqqkmqhqq
2-8 q: nqnqbdgm
6-11 b: bbbbmbbqbbb
5-14 q: qqqqpbqqqqqqqgqq
2-5 p: prprwh
13-14 k: kkkkkkkkkkkkkkkk
2-7 v: vnvvdlwvd
2-3 t: hpsqzxrltrwbttwgbz
1-5 n: srnlwnnkjnnwhnf
2-3 r: dtlcv
2-5 h: hhthhdcm
2-11 d: rdxfbdhqpbdjjlhf
1-4 b: bxbshbjr
4-10 s: sthspqlnsst
1-10 h: mhwpfrbhhbn
16-18 g: gggggggglgjgggqcgzgg
3-4 d: dddd
12-16 h: dhhhhhhhshhhmnlhhhh
15-19 q: qmqkqqzqtqdqnqqzqqz
14-15 p: kgjpqpppppqpdpph
4-6 z: zzlzzztbbzzr
11-14 l: blllwlqmhlllldllll
2-4 q: qqrqc
5-6 r: qrrvrrr
2-4 f: fffv
13-15 v: vkvvvpvvvvvvvhvvvv
3-8 k: kzqkkkkkk
4-10 w: wvkwwcwxkwv
2-6 t: tvtttttttt
3-4 t: tttt
11-12 p: pzpzppplplppppk
6-12 p: pppppdpppppgp
5-9 w: wwwwwwwzwwww
4-6 m: mmmmmhmmq
4-9 j: xsqjsllnjj
6-9 c: zmcdccgtfccbccfc
4-5 p: vwpzhpp
15-16 v: pjtmwtrxmjnjfkvgrv
9-10 p: pppppppspp
2-10 f: vffzxnfnxfcfcsmtrncz
5-7 v: blwvvvvfvvh
12-16 z: zzzzzzzzzzzzzzzr
5-6 z: zkvhpz
9-13 w: wwnwwwwwwwwww
5-6 p: wmlhpptppmfvngh
9-11 r: rrrrrgsrrdrmrrrr
2-5 b: bbbbzb
13-15 r: rcrrrrrlrrrrqgfrrnr
5-7 k: klkmkkk
3-4 f: zfffgdnfff
3-4 q: qjbjhzltvl
17-19 w: wwwwwwmwwwwwwwwwqwqw
7-9 l: nlrldrlvlnvllllvf
8-9 m: mmmmmpmmm
11-16 k: kkmkkkwkkkkbkkkkd
11-14 s: mvsdsnsncsssrs
6-17 j: jjjjjgzjjsjjjjjjjjd
19-20 p: ppppppppppppppppppkp
1-16 k: nkkkkkkktkkxkkxz
2-4 c: xkcccvvcv
3-4 v: vvvvvkn
11-13 q: qqqqqqqqqqsqj
10-13 g: gxggggggggggg
3-4 x: xxpx
4-7 d: dvbddcdhdd
17-18 g: gggggggggggggggglbgg
18-19 m: mmmmmmmmmmmmmmmmsmtm
4-6 g: xbtgrgbgggmgcrx
8-13 w: wtwcwnwwwcwssxwpbw
2-3 v: vcsv
4-5 g: gggpt
2-3 g: tggtpgkg
3-4 p: pglt
9-12 v: vvvvvvvvvvvvn
11-15 f: fhffffffffnfffq
2-5 s: snssk
2-3 m: mmmm
10-14 x: xxmjbxbxkbwjxxxxj
5-14 l: lmlmlczxfsllzpkljt
6-12 n: nnnxpjtbjjdnrnsvxnwt
5-9 s: ssssfsssb
3-11 f: bffrlbwzfpf
3-4 t: twtt
1-4 r: rkxrsrlrr
7-8 x: xxxxxxlf
9-15 d: nddbddddxdddrdntdd
16-18 v: vrxvwgbqtlkzprlvwvrk
9-10 l: lllllllllzlll
3-18 l: mfllwjggswwjjgrnrl
5-7 j: jjjtjxjvqjjltjj
5-14 n: nnnnnnnnnnnnnnqn
3-12 l: pllqlhpllpklcds
2-5 f: fsgfrpfflq
4-8 q: xqsfqqqrqhqjsqndz
1-5 c: hcttt
13-14 r: rrrrrrrrrrrrrgrr
4-6 d: dddddt
3-4 d: tdqgdk
14-15 s: snskdsjxpsgmbsssssf
3-5 m: mhlcxmmmw
2-12 c: ccmccchbrrscv
14-16 c: ccccccrccccccccmc
8-17 w: pwqmtwwwwrwxwtmmww
5-8 h: hhhhmhhmlb
10-12 b: bbbqwbbbbbbb
6-7 n: nxnnnnl
7-10 v: vcvgvtgvvkwvtlvcv
10-11 t: ttttttktttttttt
2-5 t: tzdtkpsf
4-5 r: rrrmhr
9-10 w: wcdwxgxrwwwk
1-6 g: jggggcg
1-7 v: vvvvvvvmv
12-15 q: rqqqqkqqqjqqbqqqqqrq
3-10 w: vwwgwwwzwwwwxwwxsw
3-4 c: mmhfccccjclccrdccc
1-5 m: mmmmm
4-5 h: vhhxh
13-14 z: zzbzzzzzzzzzbcz
9-11 k: bkkskkkkkkk
1-6 j: jxvjrm
4-6 f: ffffff
3-5 m: mmmmmm
1-3 x: xxxxxxxxxxx
16-17 f: fffffffffffvfffrxf
3-4 f: fwff
2-11 j: zvbdwnthjfh
9-10 f: gffffffffff
1-3 z: zmrnxvs
5-16 k: llkdkrkvkkhkktkktlkd
9-13 z: mvjzzzkhzvzxzqmf
4-5 d: flgsdd
2-6 p: mftwthqkqqkp
2-4 f: vfff
7-12 w: swwwwwwwfwwwwqwfvw
10-13 c: csdkvcctnccncczc
12-15 q: qqqqqqhvqqqmqqcfqq
2-8 v: gvkfgbzvvmfmg
3-14 m: txwnzwhmcrnnltc
8-13 v: zsvmsddwnkvrkgmx
12-13 f: fffffffffffff
1-16 g: trrkggqglgbbgljx
13-14 c: ccxcccccccmccd
9-12 x: xxxxxxxxcxxlxx
10-14 q: qqqfcqwqqpqqqs
11-16 l: xllllllllllllbll
12-13 v: vvvvvvvvvvvvvv
17-18 g: gggggxggggggggggpcg
1-5 x: xxrxxklxgw
4-5 f: fffqt
10-11 l: llllbklllsgxllr
6-9 r: crfmrsjhpf
4-8 h: hhhchhhx
6-12 v: cvlvvvtbqcsvvzvlztv
2-3 x: bsgfvxdl
2-5 j: njzjjj
13-14 s: ssssssssssssfw
8-11 l: jllfllllllmlllll
2-11 p: pxppppppphq
6-9 f: crtfxvfmwwdvt
3-5 n: nnnnnn
3-4 h: hhhh
3-5 d: kldhd
18-19 x: xxxxxxxxxxxxxxfxxbs
4-5 k: kkkct
9-12 n: nxlnnpnnwnnb
2-4 g: gqggz
15-16 z: zzzzzzzzzzzzzzzz
8-10 p: kpcppjbrzqpfcpgppp
5-6 g: qggggrg
7-8 c: cccfncccccc
2-8 k: hgnsbkckkkqktkstks
3-14 x: xxlxjxxxxxxxxvxfbx
1-8 l: lllllllll
1-2 p: ptbmvp
10-15 k: jkkkkktkkkkkkkkkknzg
6-11 k: kkkkdgkkkkk
7-8 m: mmmmmmmm
13-19 z: zzzzzzzkzzzzkzzzvzxz
2-4 g: tghm
3-8 b: bbbbbvdb
6-8 d: dddddrvxdddfdd
5-10 m: mnmnsmmmmxmd
1-8 r: cgcnqrvfb
16-17 l: mhjqbmhszwllqqllr
2-4 s: csssts
7-10 j: jjjjjjzjqt
1-12 x: xmxtxxxxxtxxzdxx
5-6 w: wwnwmwrw
10-11 p: lpjpgpqpkpprdpppp
8-9 k: zhkkbkfkk
1-2 j: klhz
6-13 d: dmstddpddtddddddd
1-8 h: khvcwhhhhlj
8-11 s: bsssbzsfdrsssss
1-18 s: xsssssssssssssssstss
8-15 l: xjllsmjtlllmsxll
1-5 m: mmmmmm
17-18 k: kkkkkkkkwkkkkkkkbmk
1-7 t: tttttgtdclpkx
4-14 k: tgvzgdwkgtcdrd
2-3 z: tzprzcdzhnnll
2-4 j: rntmnjxbwq
5-6 r: rrnjnr
5-9 g: lrggvfggp
4-5 s: sssdl
4-18 h: hhhhhghphbshhhhhhhhh
4-6 s: sfpjvsk
1-10 m: fwgstfsjmtp
4-8 w: wpwwwwwmwsh
2-19 l: lnllllllllllllllllwl
4-15 v: vmwhvvwvvvvsvtdvvkv
5-6 p: lpppslppjppp
5-7 p: ppzppcmdppt
14-18 f: mffxfftfwffdffffffff
4-7 v: kvvdvjvvkmh
1-7 p: rdkzpkfdpzrxq
2-3 h: cdhhngnnjslfjbh
3-6 q: qqzqqwqt
5-10 s: kpcsszfcwsh
11-12 g: gggggggggggw
14-15 w: wwwwwwwwwwwwwsp
6-10 h: bhkzhhhsbhhh
3-4 l: fcnvfxtln
2-7 j: jzsjfrjjjmxqjxjjss
6-9 s: nvdhnsbhsdwxhlj
1-2 v: vvrp
2-5 h: qhnbhfbsdhs
3-4 x: xqvzps
3-4 m: mcmm
9-11 l: srdlflnwlrl
1-8 x: cxjgmlgwvqdpnbzn
3-4 q: qqqk
4-5 r: wsdlmbdv
1-3 d: tbtdddp
3-8 g: gsggsggvgggpgrgx
5-7 t: ktzrvktqpllxwzt
1-2 s: spss
6-19 d: dtjdmqdldddbdcnzkqpd
9-11 f: fffffffffzf
1-12 g: wggnvsgcrgmx
5-7 f: qfpzfmkfmfjc
14-15 j: jhjjjjjjxqjdvvfj
6-7 v: vvtvvqs
4-11 q: qqqxqcqjqqmqqgt
1-3 l: gbkhxlzld
1-4 s: pssz
13-16 x: xxxxxxxxxxxxfsxpp
3-6 p: mlptcpvcrppn
13-15 x: xxxxxxxxxxxxxxxxx
13-14 f: ffffffffffffff
2-5 j: jjpwj
2-7 r: xrrzrvrkjr
8-9 m: mmhlmhmmmpzpmmhgmvz
3-4 g: zgggdwgggdl
6-9 t: tttttxjzttttr
1-4 h: njzthhch
3-14 x: xprxtxbpxxxxlg
9-15 q: qqqqqjqqqqqqhqqqqq
4-6 w: wwfwwwrb
6-8 w: wwwwwwww
10-11 k: kkkkkkkkksl
3-4 n: nnqfvfn
11-13 c: ccccccccccccc
5-9 n: vnvnmnnnqfnq
13-14 f: ffpzrfflffffffqffff
17-18 p: ppppppppppthpppppzp
3-8 m: hsmzgwdmm
4-7 z: zlzhtzcnzzzz
6-13 b: bvbbbhbbbbbbgbb
11-16 x: lpxtdgxvzbxpcwxc
10-14 d: dddddddddrddddddd
2-5 j: lhjnv
2-3 p: pdkp
3-10 l: lnllqjpgqfl
1-4 t: ttttttt
4-8 q: qxzqqqfczksrwmmzx
1-4 l: lllll
5-19 z: ttzhzcbczmjxzrjzpwz
4-7 s: sgssssjs
12-13 s: sssssssssssbq
9-12 h: hhhlchhhvhwb
5-13 n: fncqnnnnwkhnn
10-13 g: ggggjggggrgcqgg
8-12 q: qqxqvqqmqrpdrxqq
5-6 l: ldwlvnllwq
12-15 v: cvvvkvvvvvvvvrvvvl
6-11 x: kxmthvnkgxq
6-9 n: nfdfnkmnln
3-5 x: nqcxt
2-7 p: tpgkbpwxhpzldtmrqd
8-9 r: rrrsrrzrrmrr
3-10 x: fmmjlxbqlz
1-10 g: cngggggqghf
10-11 r: frrrrrrrrgj
2-5 q: sqgqq
7-8 x: cxxxwxsvjgxx
8-16 t: ttttttgpttqttttt
4-8 n: ndznlllnqwpmnnfwvxb
4-15 j: jjbszvrjjjjfjjjwjjcj
4-5 c: ccvrlc
17-19 f: ffffkpfffjxffwffcff
3-4 z: qfzzz
7-9 s: szssssjsm
13-18 q: lngqqpvqqdjvcqdqvlq
7-8 b: bbbbbbbb
2-4 n: lnqr
11-13 k: kkkkkgkkkqxkhfk
2-4 g: tggqzdxp
3-5 t: ttvtft
2-4 v: pzbbr
1-4 h: thhhh
2-5 m: mqxdt
8-9 k: kkkkkkkkk
2-6 w: jqfwlhv
17-18 x: xhxxxkxxxxxxxxxxxbxx
9-10 p: ppwppdpxvvjzpp
10-16 h: hmhjpxmhvnhqhjfmb
11-15 k: kkxkkkkkkgckkkcs
5-9 b: cwcbjsqbdwmbw
10-11 z: zzzzzzzzzzz
14-16 w: wptvwbwdwwwwwwww
8-10 c: xccclcchcrvtqc
7-12 r: rhnrrrrrrrkqrrtm
3-5 h: hhrhph
7-10 c: wblrcccpctnhvdc
15-17 n: nnnnnnnnnnnnnnnnn
5-13 s: ssssssssrssmslsssv
8-19 k: pvqbhlzkwpnkcgkvkwk
4-5 s: pkrxgskxsswbqwlfxsvw
5-10 d: ddsbdcdsdd
12-13 q: hwrkqrhqrrxmw
5-15 b: blcbfqbgbnghjbnglbbb
1-3 z: zzczzz
3-14 s: jsxssskvsssptw
8-13 n: nnnnknnnnnnnnnn
3-11 c: ccccccccccbccccc
1-6 n: nnnlbn
9-12 k: qkkkkkkkkxwkkk
19-20 w: wwwwwwwrwwwwwwwwwwww
10-15 n: nnnnnnndnnndfnnnn
8-14 c: cvndjxlcsccwxl
1-3 v: vrvwv
8-10 s: rshsssjssss
2-10 n: nnjnnnnnnhnkm
1-2 c: ccbcflcp
3-6 v: jtntcsvvvhp
3-5 q: qqqql
17-19 p: ppppppppppppppppmpg
10-11 k: kkkkkkkkktrk
2-4 f: tgprtftkfx
8-9 x: xxxxxxxld
4-6 l: lhzllllzhv
8-9 g: bhgkfgsggxg
5-9 d: dkdddddmdwd
2-13 s: sdffzhrpbnvtswxsbrcs
7-8 q: qjqpdqvwqqdtxpq
5-8 n: lncnfnzxtsn
8-9 p: khtrxgvhtqwrfpqrd
2-4 s: zhln
5-6 q: bqqqddp
7-13 g: gggjggggggggg
10-12 w: wwwwwwwwwkww
1-4 b: bwbbdbhbl
9-18 j: jjjjjjjjjjjjjjjjjjj
10-18 j: jjjvjjjtjjqjjjjfbjd
11-13 m: mmdmmmmmdmmmqm
6-9 n: nnnndtnvfnn
2-3 q: qckq
16-17 x: xcxxxxxxxxxxxxxpxx
14-17 k: kkkkkkkkqkkkkkkck
3-8 l: llkllllvl
8-13 p: nkptlpntkcknppwpdhb
6-12 s: ssssssssssss
8-14 c: ccccccccccccccccsc
6-9 p: cpppdnppztxbpp
8-12 w: vshmsmbckwjmw
1-10 g: qqtfmmxnbg
1-6 m: mmkmmmfmw
5-8 v: vvvwxvvdqv
7-8 f: ffffffff
2-10 k: kkkkkkkkkk
1-4 g: wjhxhq
3-4 w: znpwwmwcwjgs
5-9 d: ddddrdddwl
6-8 j: kjjhvzrbrwcjjm
2-5 j: jhjjxjjsj
2-6 t: ccwdcm
4-12 q: qlqrsgqqhqqf
13-16 w: mwwwwwhwwwwwwwwwww
9-10 g: ggggggggggmtgwj
1-3 x: xxxx
1-3 n: jxtqjbhpkgrcrdrptvd
14-15 w: wwhwwwwwwwwwwww
7-10 d: wddddzvdddkdm
1-4 p: lzph
6-9 w: wwwzwswwr
17-18 t: kjtktrtfgkhpzthvsjt
12-13 j: jjjjjjjjjjjxs
8-9 r: srrzrmrxnhrrr
1-5 s: spzsshkzfmkdss
1-7 z: zzsmzzhzzxzzzzz
1-2 d: ddvx
2-9 h: hhhhhhhhhhh
6-8 p: ppppppppx
4-8 v: bqvvxmvtvhfvv
3-4 z: zzzz
2-4 r: rrrrrrr
4-5 r: mhrrrrrrq
5-6 b: nkhgfjrzqldbbbbmpx
7-8 n: nnnsnwnncdnn
13-15 p: pppntwcpppppppv
5-11 r: tmkrdcmrpcrrkrl
3-4 v: vvgf
4-5 j: jjvtcj
3-5 p: ppppp
1-3 r: mrrr
13-14 v: vvvvvsvvnvvvhxvvv
10-14 z: ltwsklmfdpvxmxgq
16-17 b: bbbbbbbbbbbbbbbqqbbb
3-8 q: qbpqpvqll
9-10 x: xxxxqtxxzxxxx
8-12 d: pdddnddcbcdx
2-3 m: fmmmsfmvcmkc
9-10 x: slxtnxxtjnnxjnq
5-13 h: hhshhhhvhffhhn
6-14 t: wwwmqttttkpmqtrt
1-5 b: mbbbb
10-12 k: kfkkpkrkkkkkkkh
5-6 m: mnlmbvmm
5-6 x: xxxxvl
5-7 b: dbbbpbc
2-19 t: qhdtkxjzdcwjqjkglpzr
1-4 h: hhgqhnhhhhfhhh
1-10 b: bqbbbbzbbbbbbwb
2-3 b: dbbkgnxmbtpg
3-8 r: rrrjrgrrwq
4-7 s: ssrfwfgvskmssws
13-14 m: smdmmmmmgmfmmjs
13-15 h: hhhshhwhjhhhhhhhh
12-13 n: nnnnnnnnnnnnnn
6-14 n: ndnnpqwrlgfrmn
3-16 m: rldkmmmkhmsmbnqbmgs
2-3 m: rmmmmm
5-9 x: xxxxfxxstxxs
4-8 b: bgbbbbgbbbb
9-11 c: kwcclccccscxp
10-17 v: vvvvvvvvvvvvvvvvvv
13-18 n: nrnnnnnnnnnnfnnnnpn
3-4 c: hbcc
13-14 w: wwgwwwwwwwwwwc
4-6 z: fwmzzzz
12-15 h: vhhfhhhhhwhrhhlkmhhh
1-5 v: jqvvhvvbt
4-5 n: vnnscn
5-6 n: qnrvnnndnffnkknfrdt
6-7 w: wwwwwvznwwwwww
6-12 h: hvhhhdhhhhhr
4-5 m: vtmmmmdmp
8-9 f: ffffffffffffffffdf
5-11 z: zzzzjzhzgjwzzhlz
8-10 d: mdnnfwswns
4-15 c: rptccckzhgcvlccbh
4-5 r: brrrgtd
4-15 x: rxsfxqhhzxdsxqxgw
8-9 c: ccccclcccccccc
2-9 l: mwltgglzztlpllgf
12-13 g: nnjgzggjkgzgd
4-6 j: jjfjjnj
11-14 m: mmfqpmkmmmmmmmrm
6-7 c: cccccqccmccccc
6-9 f: ffzgcfcpfwztjk
6-9 r: sjgrxnrvnqmmlxdrsp
3-11 c: cchwcfcckcn
7-10 p: jpzdflzgkxnbhj
5-6 b: bblblp
7-8 p: ppppppllppp
10-13 b: bbbbbvbbggbbb
5-6 p: pppptp
2-6 t: qttttjtt
3-6 n: vwlhczrnwpnvrnl
8-9 r: jrrdrrrjwrrrrrs
3-4 n: nnwqn
4-8 b: mbscbwxn
10-12 v: tqbvxmlqvvvv
1-9 l: qcllllncllcllllrn
6-10 b: gbbxfblbbx
11-13 g: gggqgggtgggtgrgsg
2-3 f: fjkz
5-11 t: tttttttttttt
5-18 j: zjdxgjjpshjjkjbtjvg
9-11 k: kjkfkwkkrkgk
1-8 w: hwhcwwbffvcdwzwbww
7-16 l: rrljlvlmmlssllkllqj
1-4 d: hddldvddddf
7-9 b: bgbbbrmblb
2-5 v: ltvvvv
5-6 r: rgrrdvrrrrrrr
8-9 n: wnnnnnnnn
1-8 q: sfmbjqqwvqqq
2-11 b: wblbmlrcwffl
4-5 n: cfmnn
15-16 g: gggggggggggggggq
6-10 x: xxxxxxxxltxxx
5-9 g: gggbgxgggpgn
8-10 z: zzztjzzzqzp
4-5 x: xxxfl
6-10 v: vvvhvvvvvv
6-8 v: tdrvsnvpvzxbwvv
8-11 q: qqqqqqqqqqjqqq
12-13 z: zjzzzvzjkzzzz
1-8 b: bsqqmbnbcwhkphfh
1-5 z: zdjzzrm
3-4 m: vlmmtbmmxcdkmdmfb
7-14 k: kkwpcjfkkkrknzkk
1-3 f: cfbljmpfghhgxdbg
6-7 n: mrnhnxn
16-17 g: gggggggggggggggmr
7-8 q: qqqkqhqqwkpzshq
9-15 j: jjjjjjjjjjpjjjj
5-6 t: tttttl
4-15 h: hhhhhbsbphhhlzgh
4-6 h: qhhlhh
2-6 f: wfwdff
1-7 c: rczccfx
3-8 b: jkznbbbqlk
8-14 r: srtchmrjxmzznm
4-8 s: ssgskspsdsmclrmxzp
9-12 j: kjjjfcjjljjqjj
3-5 l: lllvllll
15-16 s: sssssssssssssszs
5-6 z: zzzzmfjz
13-14 v: vnvvgvvvvwvvfrvspv
7-8 t: ttttttkst
17-18 f: ffffffffffffffffhx
8-11 b: bbbkbswbbpbnbbbbx
7-14 s: ssjfssssssjsdp
6-8 s: sssssqsps
5-8 h: hhdhphhmhhhh
8-9 r: prrmrpsrrrvrzrrrsrn
4-17 t: ttttjttjttthtktttt
7-9 v: tvvwvpvrbnvvvv
8-12 j: plfsgrjjgjrjwcgc
2-7 r: krqzzprxrldwg
4-11 k: sfpkkkcwkwk
2-3 z: zzhp
6-9 h: xkjwshvmhbjhfjvkwcmh
4-8 d: dvndvmdzn
3-6 r: wrrrrr
6-8 g: kggdgfgzz
3-5 j: jjjjj
2-9 x: qkksvkxxvxbxx
12-17 b: kjpbpbmddcnwbbbxb
2-10 w: rwpbpbwrbmwgwwvghvg
1-12 f: fbfqmffffftf
1-8 z: qvbjgplznjztjvqjhv
1-5 b: bbbbbbbbb
7-11 p: kddppkdtqpjcfpp
14-20 z: zzzzzmzzzzzzzzzzzzzz
7-8 p: sjspdphq
11-12 w: wpwwwwwwwwwd
7-12 d: sdddddkdjddd
6-8 g: gggfzzhglgxqpgbnbgbx
10-13 c: hcccctjcccccccn
14-16 k: kkkkkvkkkkkkkkpxk
16-18 c: ccccccccclcccccccjc
2-4 r: llrh
11-13 g: ggggggggggggm
1-4 z: zfwzzz
4-6 s: ssssfs
5-12 t: tttttntttttt
2-6 n: gnghnp
1-3 q: qqgq
10-11 f: rdzfzffhtfffffff
4-9 k: kpfhvkkkk
3-10 t: twlkttptttt
4-10 d: dkdvgkdddwd
5-12 t: ttttnttghtthtvtt
4-5 c: ctczwcccc
17-18 l: llllllllllllllllmx
2-8 t: knmttnttdjbtttvtkt
1-2 j: jdjjjj
12-16 j: wmqlfjlnxnvlrjkmj
13-17 s: snsdsssssssssssss
8-14 h: hhhhhfhhhwhphhscphd
9-10 b: bbbgbbbbqcb
15-16 z: fjjcjrwjtrcnltzz
6-8 s: ssssxjshd
2-4 k: kkkw
3-6 s: xsfgbpss
13-15 x: xxpxxxxdxxxgjxgxxx
4-5 l: llqlllsl
10-15 g: jggxgsggggggjtgg
2-6 b: prpbjbkbbkcb
7-9 h: hhhhhkfhh
8-11 f: fzhftffvffwffnl
11-15 x: xxxcxxxxxngxxxcxx
11-12 k: skkkkkkkkkxhn
5-15 n: cnnnnqqbnnnncznnp
1-3 v: vqvxlfwpjvxtpkvlhxjv
3-8 b: gfbbbsfbb
3-4 z: qzzzbczk
8-17 t: cpttttttpttttttttt
11-17 l: lprllfllllnlllllnll
7-8 f: ffffffrd
2-6 z: hghjzzwpwz
6-13 m: thzmtmcsmtctf
2-4 c: dctc
10-17 s: sssssssspzssssssl
6-10 j: jjjjljljjjjjzj
5-7 b: bbxbvsxphgrmnqgzbbx
1-11 l: rlnlllllllvlllll
13-16 b: bbbbfbnbbbbbzgbwbb
5-11 p: bpjpnpqpppjpmppphrk
1-3 l: llll
11-15 l: llgllllcllllllllfll
2-7 x: kxsnzzx
18-19 g: gglgggvqkjzgkgggzgg
3-5 j: fqvjjcjjhb
6-7 c: fccccccct
13-16 m: mzmtcgmcmmmkdmlk
5-9 w: wwsjwwwww
1-2 m: jzmj
16-18 m: mmmmmmvmmmmmmmmqwn
11-12 w: wwwbrwcwwxwwmwwrdww
3-4 v: nsvddwnvvvm
5-8 m: mjmrbpmh
2-3 t: xdrtzgdl
2-6 n: fnwwgnnzwsp
7-9 p: jpppppvppsqt
1-8 k: gkkkkkkkk
2-9 q: jqqqwfzxhqqqqsxqm
2-4 t: jtwt
6-20 d: hqdkcmkdndjrftmgjgqc
2-9 r: crgmrqpwrrr
9-15 p: pwmjlrgnrppwphg
3-4 t: ttqttttnttttt
1-5 v: hvvvv
1-2 x: ggxxxxt
17-18 m: mmmmmmmmmmmmmmmmcl
4-10 d: dxtmsjvhczfjd
8-10 x: xpbxsxpxgxqxxqxxk
6-9 f: ffffmffdwkfrlffx
8-10 m: ldmmgxxmbmnqftt
12-13 p: ppxpxhppgppqqpvppp
4-12 k: kkkkkkkgklkkjkkqvkk
3-4 x: xxcp
7-8 k: kkkkkkkr
11-14 d: dddkpddvdddddg
3-8 l: lsgmlqll
12-13 z: znzzzzzzzzzzrz
3-5 h: hhdphh
3-4 h: hqhhh
4-6 f: wfsfrffzf
8-12 k: ktkdmhvkxktkhr
2-6 d: dpdwdddd
7-12 n: nnnnnnpnnnnxn
1-3 v: vvvv
3-11 q: gmqqqqmqshpq
3-4 j: jjjjkjhjf
2-4 b: glbxb
13-14 s: ssssssssssrssds
16-18 d: dddddddddddddddddd
3-9 g: fgggzttsg
11-12 r: grrrrrrqrrrrrrr
2-5 q: cdqqv
6-11 l: lfclllslllxllll
2-3 d: dzdddg
2-4 n: tkwm
4-5 r: kdccjnrfrzrhplrz
4-16 j: tfxsmxlrjptjjrxw
16-17 p: stpsgsgwvqrzpblpsx
8-12 r: rrdrgrrgrrhrwqjmp
5-8 j: jjqjjkjjjjnv
2-7 n: wzgnnnnnn
1-3 v: vvvv
4-5 l: hlgnx
8-15 c: ccccpccczvcsccc
3-15 f: ffnfffffffffffv
4-5 w: wwjgww
10-15 d: ddddbcrddmddddld
7-11 w: wwwwwwwwwwz
3-4 h: hhhh
4-9 v: vvpgvvnvtv
8-11 q: qqqqvqqqxqcqnmq
2-5 s: lsnpdqqqsj
8-9 g: ggsgggggz
6-10 s: sssssbsbbtss
12-16 z: zhzzzszzzzznnzbwz
9-10 p: ppnpdpgldl
10-11 r: rrrrrrrlrtfrr
1-13 h: xhhrhhhhhhhhchhhhcp
5-14 m: mmmmmmmmmmmmmqm
8-9 h: hhhhchhhhhkt
3-4 f: fflf
7-13 s: ssssssssscsssjs
2-3 t: twlcfmbmbxtt
4-6 v: vdvhvf
1-7 c: bccccccccccc
13-14 r: wrrvrvrtrrrrrrrrrrr
1-3 b: sjvfpdrbcnwr
1-7 z: xzzzzwjz
6-14 j: jfrxjjjrqcqjwmbfjjjm
11-14 f: ffffffffffqffzqf
6-8 z: zzzzzrzw
1-5 j: jjjnjjjjj
9-10 g: ggggggxggg
7-9 r: rrrvrrbrdr
9-18 j: jjjjjjjjnjjjjjjjjfjj
14-18 q: kjtxqqqqltlpgqshdx
8-12 k: kkkkkkwjkkkfkkk
2-4 s: ssvs
3-5 z: zzfjk
9-10 m: rmmlmsmfmbj
14-15 z: nlzzzzzzzzzdzzzzzz
8-12 r: zrrrrprrxrrrrkrhk
1-2 z: qlfzd
1-6 j: kqjpjzpsgjjqz
1-5 s: qfssks
2-5 r: nrrzrr
4-6 g: kggggg
6-7 c: cccccdqcc
2-6 x: vjkxbrfwnj
16-18 s: kssssssswssssssssssb";

        static void Main(string[] args)
        {
            var entries = Input.Split(Environment.NewLine, StringSplitOptions.RemoveEmptyEntries);
            var valid = 0;

            foreach (var pwdEntry in entries)
            {
                var parts = pwdEntry.Split(':');
                var rule = parts[0].Split(' ');
                var range = rule[0].Split('-').Select(int.Parse).ToList();
                var requiredChar = rule[1][0];
                var password = parts[1];

                var count = password.Count(p => p == requiredChar);
                if (count >= range[0] && count <= range[1])
                    valid++;
            }

            Console.WriteLine($"Valid passwords = {valid}");
        }
    }
}
