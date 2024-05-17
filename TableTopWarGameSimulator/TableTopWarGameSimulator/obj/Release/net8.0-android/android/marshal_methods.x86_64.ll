; ModuleID = 'marshal_methods.x86_64.ll'
source_filename = "marshal_methods.x86_64.ll"
target datalayout = "e-m:e-p270:32:32-p271:32:32-p272:64:64-i64:64-f80:128-n8:16:32:64-S128"
target triple = "x86_64-unknown-linux-android21"

%struct.MarshalMethodName = type {
	i64, ; uint64_t id
	ptr ; char* name
}

%struct.MarshalMethodsManagedClass = type {
	i32, ; uint32_t token
	ptr ; MonoClass klass
}

@assembly_image_cache = dso_local local_unnamed_addr global [114 x ptr] zeroinitializer, align 16

; Each entry maps hash of an assembly name to an index into the `assembly_image_cache` array
@assembly_image_cache_hashes = dso_local local_unnamed_addr constant [228 x i64] [
	i64 98382396393917666, ; 0: Microsoft.Extensions.Primitives.dll => 0x15d8644ad360ce2 => 43
	i64 120698629574877762, ; 1: Mono.Android => 0x1accec39cafe242 => 113
	i64 131669012237370309, ; 2: Microsoft.Maui.Essentials.dll => 0x1d3c844de55c3c5 => 47
	i64 196720943101637631, ; 3: System.Linq.Expressions.dll => 0x2bae4a7cd73f3ff => 89
	i64 210515253464952879, ; 4: Xamarin.AndroidX.Collection.dll => 0x2ebe681f694702f => 53
	i64 232391251801502327, ; 5: Xamarin.AndroidX.SavedState.dll => 0x3399e9cbc897277 => 70
	i64 750875890346172408, ; 6: System.Threading.Thread => 0xa6ba5a4da7d1ff8 => 105
	i64 799765834175365804, ; 7: System.ComponentModel.dll => 0xb1956c9f18442ac => 83
	i64 805302231655005164, ; 8: hu\Microsoft.Maui.Controls.resources.dll => 0xb2d021ceea03bec => 12
	i64 872800313462103108, ; 9: Xamarin.AndroidX.DrawerLayout => 0xc1ccf42c3c21c44 => 58
	i64 1120440138749646132, ; 10: Xamarin.Google.Android.Material.dll => 0xf8c9a5eae431534 => 74
	i64 1369545283391376210, ; 11: Xamarin.AndroidX.Navigation.Fragment.dll => 0x13019a2dd85acb52 => 66
	i64 1476839205573959279, ; 12: System.Net.Primitives.dll => 0x147ec96ece9b1e6f => 93
	i64 1486715745332614827, ; 13: Microsoft.Maui.Controls.dll => 0x14a1e017ea87d6ab => 44
	i64 1513467482682125403, ; 14: Mono.Android.Runtime => 0x1500eaa8245f6c5b => 112
	i64 1537168428375924959, ; 15: System.Threading.Thread.dll => 0x15551e8a954ae0df => 105
	i64 1624659445732251991, ; 16: Xamarin.AndroidX.AppCompat.AppCompatResources.dll => 0x168bf32877da9957 => 51
	i64 1628611045998245443, ; 17: Xamarin.AndroidX.Lifecycle.ViewModelSavedState.dll => 0x1699fd1e1a00b643 => 63
	i64 1743969030606105336, ; 18: System.Memory.dll => 0x1833d297e88f2af8 => 91
	i64 1767386781656293639, ; 19: System.Private.Uri.dll => 0x188704e9f5582107 => 97
	i64 1795316252682057001, ; 20: Xamarin.AndroidX.AppCompat.dll => 0x18ea3e9eac997529 => 50
	i64 1835311033149317475, ; 21: es\Microsoft.Maui.Controls.resources => 0x197855a927386163 => 6
	i64 1836611346387731153, ; 22: Xamarin.AndroidX.SavedState => 0x197cf449ebe482d1 => 70
	i64 1881198190668717030, ; 23: tr\Microsoft.Maui.Controls.resources => 0x1a1b5bc992ea9be6 => 28
	i64 1920760634179481754, ; 24: Microsoft.Maui.Controls.Xaml => 0x1aa7e99ec2d2709a => 45
	i64 1981742497975770890, ; 25: Xamarin.AndroidX.Lifecycle.ViewModel.dll => 0x1b80904d5c241f0a => 62
	i64 2262844636196693701, ; 26: Xamarin.AndroidX.DrawerLayout.dll => 0x1f673d352266e6c5 => 58
	i64 2287834202362508563, ; 27: System.Collections.Concurrent => 0x1fc00515e8ce7513 => 78
	i64 2329709569556905518, ; 28: Xamarin.AndroidX.Lifecycle.LiveData.Core.dll => 0x2054ca829b447e2e => 61
	i64 2335503487726329082, ; 29: System.Text.Encodings.Web => 0x2069600c4d9d1cfa => 102
	i64 2470498323731680442, ; 30: Xamarin.AndroidX.CoordinatorLayout => 0x2248f922dc398cba => 54
	i64 2497223385847772520, ; 31: System.Runtime => 0x22a7eb7046413568 => 100
	i64 2547086958574651984, ; 32: Xamarin.AndroidX.Activity.dll => 0x2359121801df4a50 => 49
	i64 2602673633151553063, ; 33: th\Microsoft.Maui.Controls.resources => 0x241e8de13a460e27 => 27
	i64 2656907746661064104, ; 34: Microsoft.Extensions.DependencyInjection => 0x24df3b84c8b75da8 => 38
	i64 2662981627730767622, ; 35: cs\Microsoft.Maui.Controls.resources => 0x24f4cfae6c48af06 => 2
	i64 2895129759130297543, ; 36: fi\Microsoft.Maui.Controls.resources => 0x282d912d479fa4c7 => 7
	i64 3017704767998173186, ; 37: Xamarin.Google.Android.Material => 0x29e10a7f7d88a002 => 74
	i64 3289520064315143713, ; 38: Xamarin.AndroidX.Lifecycle.Common => 0x2da6b911e3063621 => 60
	i64 3311221304742556517, ; 39: System.Numerics.Vectors.dll => 0x2df3d23ba9e2b365 => 95
	i64 3344514922410554693, ; 40: Xamarin.KotlinX.Coroutines.Core.Jvm => 0x2e6a1a9a18463545 => 76
	i64 3429672777697402584, ; 41: Microsoft.Maui.Essentials => 0x2f98a5385a7b1ed8 => 47
	i64 3479543178483790054, ; 42: TableTopWarGameSimulator.dll => 0x3049d215de28f0e6 => 77
	i64 3494946837667399002, ; 43: Microsoft.Extensions.Configuration => 0x30808ba1c00a455a => 36
	i64 3522470458906976663, ; 44: Xamarin.AndroidX.SwipeRefreshLayout => 0x30e2543832f52197 => 71
	i64 3551103847008531295, ; 45: System.Private.CoreLib.dll => 0x31480e226177735f => 110
	i64 3567343442040498961, ; 46: pt\Microsoft.Maui.Controls.resources => 0x3181bff5bea4ab11 => 22
	i64 3571415421602489686, ; 47: System.Runtime.dll => 0x319037675df7e556 => 100
	i64 3638003163729360188, ; 48: Microsoft.Extensions.Configuration.Abstractions => 0x327cc89a39d5f53c => 37
	i64 3647754201059316852, ; 49: System.Xml.ReaderWriter => 0x329f6d1e86145474 => 108
	i64 3655542548057982301, ; 50: Microsoft.Extensions.Configuration.dll => 0x32bb18945e52855d => 36
	i64 3727469159507183293, ; 51: Xamarin.AndroidX.RecyclerView => 0x33baa1739ba646bd => 69
	i64 3869221888984012293, ; 52: Microsoft.Extensions.Logging.dll => 0x35b23cceda0ed605 => 40
	i64 3890352374528606784, ; 53: Microsoft.Maui.Controls.Xaml.dll => 0x35fd4edf66e00240 => 45
	i64 3933965368022646939, ; 54: System.Net.Requests => 0x369840a8bfadc09b => 94
	i64 3966267475168208030, ; 55: System.Memory => 0x370b03412596249e => 91
	i64 4070326265757318011, ; 56: da\Microsoft.Maui.Controls.resources.dll => 0x387cb42c56683b7b => 3
	i64 4073500526318903918, ; 57: System.Private.Xml.dll => 0x3887fb25779ae26e => 98
	i64 4120493066591692148, ; 58: zh-Hant\Microsoft.Maui.Controls.resources => 0x392eee9cdda86574 => 33
	i64 4154383907710350974, ; 59: System.ComponentModel => 0x39a7562737acb67e => 83
	i64 4167269041631776580, ; 60: System.Threading.ThreadPool => 0x39d51d1d3df1cf44 => 106
	i64 4187479170553454871, ; 61: System.Linq.Expressions => 0x3a1cea1e912fa117 => 89
	i64 4205801962323029395, ; 62: System.ComponentModel.TypeConverter => 0x3a5e0299f7e7ad93 => 82
	i64 4360412976914417659, ; 63: tr\Microsoft.Maui.Controls.resources.dll => 0x3c834c8002fcc7fb => 28
	i64 4377400047170144581, ; 64: Maui.DataGrid => 0x3cbfa626835ac945 => 35
	i64 4794310189461587505, ; 65: Xamarin.AndroidX.Activity => 0x4288cfb749e4c631 => 49
	i64 4795410492532947900, ; 66: Xamarin.AndroidX.SwipeRefreshLayout.dll => 0x428cb86f8f9b7bbc => 71
	i64 4871824391508510238, ; 67: nb\Microsoft.Maui.Controls.resources.dll => 0x439c3278d7f2c61e => 18
	i64 4953714692329509532, ; 68: sv\Microsoft.Maui.Controls.resources.dll => 0x44bf21444aef129c => 26
	i64 5471532531798518949, ; 69: sv\Microsoft.Maui.Controls.resources => 0x4beec9d926d82ca5 => 26
	i64 5522859530602327440, ; 70: uk\Microsoft.Maui.Controls.resources => 0x4ca5237b51eead90 => 29
	i64 5570799893513421663, ; 71: System.IO.Compression.Brotli => 0x4d4f74fcdfa6c35f => 87
	i64 5573260873512690141, ; 72: System.Security.Cryptography.dll => 0x4d58333c6e4ea1dd => 101
	i64 5692067934154308417, ; 73: Xamarin.AndroidX.ViewPager2.dll => 0x4efe49a0d4a8bb41 => 73
	i64 6200764641006662125, ; 74: ro\Microsoft.Maui.Controls.resources => 0x560d8a96830131ed => 23
	i64 6222399776351216807, ; 75: System.Text.Json.dll => 0x565a67a0ffe264a7 => 103
	i64 6300676701234028427, ; 76: es\Microsoft.Maui.Controls.resources.dll => 0x57708013cda25f8b => 6
	i64 6357457916754632952, ; 77: _Microsoft.Android.Resource.Designer => 0x583a3a4ac2a7a0f8 => 34
	i64 6401687960814735282, ; 78: Xamarin.AndroidX.Lifecycle.LiveData.Core => 0x58d75d486341cfb2 => 61
	i64 6468276347982211888, ; 79: TableTopWarGameSimulator => 0x59c3ef116e8a6b30 => 77
	i64 6471714727257221498, ; 80: fi\Microsoft.Maui.Controls.resources.dll => 0x59d026417dd4a97a => 7
	i64 6478287442656530074, ; 81: hr\Microsoft.Maui.Controls.resources => 0x59e7801b0c6a8e9a => 11
	i64 6548213210057960872, ; 82: Xamarin.AndroidX.CustomView.dll => 0x5adfed387b066da8 => 57
	i64 6560151584539558821, ; 83: Microsoft.Extensions.Options => 0x5b0a571be53243a5 => 42
	i64 6743165466166707109, ; 84: nl\Microsoft.Maui.Controls.resources => 0x5d948943c08c43a5 => 19
	i64 6786606130239981554, ; 85: System.Diagnostics.TraceSource => 0x5e2ede51877147f2 => 86
	i64 6894844156784520562, ; 86: System.Numerics.Vectors => 0x5faf683aead1ad72 => 95
	i64 7270811800166795866, ; 87: System.Linq => 0x64e71ccf51a90a5a => 90
	i64 7377312882064240630, ; 88: System.ComponentModel.TypeConverter.dll => 0x66617afac45a2ff6 => 82
	i64 7489048572193775167, ; 89: System.ObjectModel => 0x67ee71ff6b419e3f => 96
	i64 7654504624184590948, ; 90: System.Net.Http => 0x6a3a4366801b8264 => 92
	i64 7714652370974252055, ; 91: System.Private.CoreLib => 0x6b0ff375198b9c17 => 110
	i64 7735352534559001595, ; 92: Xamarin.Kotlin.StdLib.dll => 0x6b597e2582ce8bfb => 75
	i64 7742555799473854801, ; 93: it\Microsoft.Maui.Controls.resources.dll => 0x6b73157a51479951 => 14
	i64 7836164640616011524, ; 94: Xamarin.AndroidX.AppCompat.AppCompatResources => 0x6cbfa6390d64d704 => 51
	i64 7975724199463739455, ; 95: sk\Microsoft.Maui.Controls.resources.dll => 0x6eaf76e6f785e03f => 25
	i64 8064050204834738623, ; 96: System.Collections.dll => 0x6fe942efa61731bf => 80
	i64 8083354569033831015, ; 97: Xamarin.AndroidX.Lifecycle.Common.dll => 0x702dd82730cad267 => 60
	i64 8087206902342787202, ; 98: System.Diagnostics.DiagnosticSource => 0x703b87d46f3aa082 => 85
	i64 8108129031893776750, ; 99: ko\Microsoft.Maui.Controls.resources.dll => 0x7085dc65530f796e => 16
	i64 8167236081217502503, ; 100: Java.Interop.dll => 0x7157d9f1a9b8fd27 => 111
	i64 8185542183669246576, ; 101: System.Collections => 0x7198e33f4794aa70 => 80
	i64 8246048515196606205, ; 102: Microsoft.Maui.Graphics.dll => 0x726fd96f64ee56fd => 48
	i64 8368701292315763008, ; 103: System.Security.Cryptography => 0x7423997c6fd56140 => 101
	i64 8386351099740279196, ; 104: zh-HK\Microsoft.Maui.Controls.resources.dll => 0x74624de475b9d19c => 31
	i64 8400357532724379117, ; 105: Xamarin.AndroidX.Navigation.UI.dll => 0x749410ab44503ded => 68
	i64 8563666267364444763, ; 106: System.Private.Uri => 0x76d841191140ca5b => 97
	i64 8626175481042262068, ; 107: Java.Interop => 0x77b654e585b55834 => 111
	i64 8639588376636138208, ; 108: Xamarin.AndroidX.Navigation.Runtime => 0x77e5fbdaa2fda2e0 => 67
	i64 8677882282824630478, ; 109: pt-BR\Microsoft.Maui.Controls.resources => 0x786e07f5766b00ce => 21
	i64 8725526185868997716, ; 110: System.Diagnostics.DiagnosticSource.dll => 0x79174bd613173454 => 85
	i64 9045785047181495996, ; 111: zh-HK\Microsoft.Maui.Controls.resources => 0x7d891592e3cb0ebc => 31
	i64 9312692141327339315, ; 112: Xamarin.AndroidX.ViewPager2 => 0x813d54296a634f33 => 73
	i64 9324707631942237306, ; 113: Xamarin.AndroidX.AppCompat => 0x8168042fd44a7c7a => 50
	i64 9363564275759486853, ; 114: el\Microsoft.Maui.Controls.resources.dll => 0x81f21019382e9785 => 5
	i64 9551379474083066910, ; 115: uk\Microsoft.Maui.Controls.resources.dll => 0x848d5106bbadb41e => 29
	i64 9659729154652888475, ; 116: System.Text.RegularExpressions => 0x860e407c9991dd9b => 104
	i64 9678050649315576968, ; 117: Xamarin.AndroidX.CoordinatorLayout.dll => 0x864f57c9feb18c88 => 54
	i64 9702891218465930390, ; 118: System.Collections.NonGeneric.dll => 0x86a79827b2eb3c96 => 79
	i64 9773637193738963987, ; 119: ca\Microsoft.Maui.Controls.resources.dll => 0x87a2ef3ea85b4c13 => 1
	i64 9808709177481450983, ; 120: Mono.Android.dll => 0x881f890734e555e7 => 113
	i64 9956195530459977388, ; 121: Microsoft.Maui => 0x8a2b8315b36616ac => 46
	i64 10038780035334861115, ; 122: System.Net.Http.dll => 0x8b50e941206af13b => 92
	i64 10051358222726253779, ; 123: System.Private.Xml => 0x8b7d990c97ccccd3 => 98
	i64 10092835686693276772, ; 124: Microsoft.Maui.Controls => 0x8c10f49539bd0c64 => 44
	i64 10143853363526200146, ; 125: da\Microsoft.Maui.Controls.resources => 0x8cc634e3c2a16b52 => 3
	i64 10209869394718195525, ; 126: nl\Microsoft.Maui.Controls.resources.dll => 0x8db0be1ecb4f7f45 => 19
	i64 10229024438826829339, ; 127: Xamarin.AndroidX.CustomView => 0x8df4cb880b10061b => 57
	i64 10406448008575299332, ; 128: Xamarin.KotlinX.Coroutines.Core.Jvm.dll => 0x906b2153fcb3af04 => 76
	i64 10430153318873392755, ; 129: Xamarin.AndroidX.Core => 0x90bf592ea44f6673 => 55
	i64 10506226065143327199, ; 130: ca\Microsoft.Maui.Controls.resources => 0x91cd9cf11ed169df => 1
	i64 10761706286639228993, ; 131: zh-Hant\Microsoft.Maui.Controls.resources.dll => 0x955942d988382841 => 33
	i64 10785150219063592792, ; 132: System.Net.Primitives => 0x95ac8cfb68830758 => 93
	i64 11002576679268595294, ; 133: Microsoft.Extensions.Logging.Abstractions => 0x98b1013215cd365e => 41
	i64 11009005086950030778, ; 134: Microsoft.Maui.dll => 0x98c7d7cc621ffdba => 46
	i64 11103970607964515343, ; 135: hu\Microsoft.Maui.Controls.resources => 0x9a193a6fc41a6c0f => 12
	i64 11156122287428000958, ; 136: th\Microsoft.Maui.Controls.resources.dll => 0x9ad2821cdcf6dcbe => 27
	i64 11157797727133427779, ; 137: fr\Microsoft.Maui.Controls.resources.dll => 0x9ad875ea9172e843 => 8
	i64 11162124722117608902, ; 138: Xamarin.AndroidX.ViewPager => 0x9ae7d54b986d05c6 => 72
	i64 11220793807500858938, ; 139: ja\Microsoft.Maui.Controls.resources => 0x9bb8448481fdd63a => 15
	i64 11226290749488709958, ; 140: Microsoft.Extensions.Options.dll => 0x9bcbcbf50c874146 => 42
	i64 11340910727871153756, ; 141: Xamarin.AndroidX.CursorAdapter => 0x9d630238642d465c => 56
	i64 11485890710487134646, ; 142: System.Runtime.InteropServices => 0x9f6614bf0f8b71b6 => 99
	i64 11518296021396496455, ; 143: id\Microsoft.Maui.Controls.resources => 0x9fd9353475222047 => 13
	i64 11529969570048099689, ; 144: Xamarin.AndroidX.ViewPager.dll => 0xa002ae3c4dc7c569 => 72
	i64 11530571088791430846, ; 145: Microsoft.Extensions.Logging => 0xa004d1504ccd66be => 40
	i64 11855031688536399763, ; 146: vi\Microsoft.Maui.Controls.resources.dll => 0xa485888294361f93 => 30
	i64 12145679461940342714, ; 147: System.Text.Json => 0xa88e1f1ebcb62fba => 103
	i64 12451044538927396471, ; 148: Xamarin.AndroidX.Fragment.dll => 0xaccaff0a2955b677 => 59
	i64 12466513435562512481, ; 149: Xamarin.AndroidX.Loader.dll => 0xad01f3eb52569061 => 64
	i64 12475113361194491050, ; 150: _Microsoft.Android.Resource.Designer.dll => 0xad2081818aba1caa => 34
	i64 12517810545449516888, ; 151: System.Diagnostics.TraceSource.dll => 0xadb8325e6f283f58 => 86
	i64 12538491095302438457, ; 152: Xamarin.AndroidX.CardView.dll => 0xae01ab382ae67e39 => 52
	i64 12550732019250633519, ; 153: System.IO.Compression => 0xae2d28465e8e1b2f => 88
	i64 12700543734426720211, ; 154: Xamarin.AndroidX.Collection => 0xb041653c70d157d3 => 53
	i64 12843321153144804894, ; 155: Microsoft.Extensions.Primitives => 0xb23ca48abd74d61e => 43
	i64 12989346753972519995, ; 156: ar\Microsoft.Maui.Controls.resources.dll => 0xb4436e0d5ee7c43b => 0
	i64 13005833372463390146, ; 157: pt-BR\Microsoft.Maui.Controls.resources.dll => 0xb47e008b5d99ddc2 => 21
	i64 13343850469010654401, ; 158: Mono.Android.Runtime.dll => 0xb92ee14d854f44c1 => 112
	i64 13381594904270902445, ; 159: he\Microsoft.Maui.Controls.resources => 0xb9b4f9aaad3e94ad => 9
	i64 13465488254036897740, ; 160: Xamarin.Kotlin.StdLib => 0xbadf06394d106fcc => 75
	i64 13540124433173649601, ; 161: vi\Microsoft.Maui.Controls.resources => 0xbbe82f6eede718c1 => 30
	i64 13572454107664307259, ; 162: Xamarin.AndroidX.RecyclerView.dll => 0xbc5b0b19d99f543b => 69
	i64 13717397318615465333, ; 163: System.ComponentModel.Primitives.dll => 0xbe5dfc2ef2f87d75 => 81
	i64 13881769479078963060, ; 164: System.Console.dll => 0xc0a5f3cade5c6774 => 84
	i64 13959074834287824816, ; 165: Xamarin.AndroidX.Fragment => 0xc1b8989a7ad20fb0 => 59
	i64 14014210090002754064, ; 166: Maui.DataGrid.dll => 0xc27c79d38e4f2a10 => 35
	i64 14124974489674258913, ; 167: Xamarin.AndroidX.CardView => 0xc405fd76067d19e1 => 52
	i64 14125464355221830302, ; 168: System.Threading.dll => 0xc407bafdbc707a9e => 107
	i64 14349907877893689639, ; 169: ro\Microsoft.Maui.Controls.resources.dll => 0xc7251d2f956ed127 => 23
	i64 14461014870687870182, ; 170: System.Net.Requests.dll => 0xc8afd8683afdece6 => 94
	i64 14464374589798375073, ; 171: ru\Microsoft.Maui.Controls.resources => 0xc8bbc80dcb1e5ea1 => 24
	i64 14491877563792607819, ; 172: zh-Hans\Microsoft.Maui.Controls.resources.dll => 0xc91d7ddcee4fca4b => 32
	i64 14551742072151931844, ; 173: System.Text.Encodings.Web.dll => 0xc9f22c50f1b8fbc4 => 102
	i64 14610046442689856844, ; 174: cs\Microsoft.Maui.Controls.resources.dll => 0xcac14fd5107d054c => 2
	i64 14669215534098758659, ; 175: Microsoft.Extensions.DependencyInjection.dll => 0xcb9385ceb3993c03 => 38
	i64 14705122255218365489, ; 176: ko\Microsoft.Maui.Controls.resources => 0xcc1316c7b0fb5431 => 16
	i64 14735017007120366644, ; 177: ja\Microsoft.Maui.Controls.resources.dll => 0xcc7d4be604bfbc34 => 15
	i64 14744092281598614090, ; 178: zh-Hans\Microsoft.Maui.Controls.resources => 0xcc9d89d004439a4a => 32
	i64 14852515768018889994, ; 179: Xamarin.AndroidX.CursorAdapter.dll => 0xce1ebc6625a76d0a => 56
	i64 14904040806490515477, ; 180: ar\Microsoft.Maui.Controls.resources => 0xced5ca2604cb2815 => 0
	i64 14954917835170835695, ; 181: Microsoft.Extensions.DependencyInjection.Abstractions.dll => 0xcf8a8a895a82ecef => 39
	i64 14987728460634540364, ; 182: System.IO.Compression.dll => 0xcfff1ba06622494c => 88
	i64 15076659072870671916, ; 183: System.ObjectModel.dll => 0xd13b0d8c1620662c => 96
	i64 15111608613780139878, ; 184: ms\Microsoft.Maui.Controls.resources => 0xd1b737f831192f66 => 17
	i64 15115185479366240210, ; 185: System.IO.Compression.Brotli.dll => 0xd1c3ed1c1bc467d2 => 87
	i64 15133485256822086103, ; 186: System.Linq.dll => 0xd204f0a9127dd9d7 => 90
	i64 15203009853192377507, ; 187: pt\Microsoft.Maui.Controls.resources.dll => 0xd2fbf0e9984b94a3 => 22
	i64 15227001540531775957, ; 188: Microsoft.Extensions.Configuration.Abstractions.dll => 0xd3512d3999b8e9d5 => 37
	i64 15370334346939861994, ; 189: Xamarin.AndroidX.Core.dll => 0xd54e65a72c560bea => 55
	i64 15391712275433856905, ; 190: Microsoft.Extensions.DependencyInjection.Abstractions => 0xd59a58c406411f89 => 39
	i64 15527772828719725935, ; 191: System.Console => 0xd77dbb1e38cd3d6f => 84
	i64 15536481058354060254, ; 192: de\Microsoft.Maui.Controls.resources => 0xd79cab34eec75bde => 4
	i64 15582737692548360875, ; 193: Xamarin.AndroidX.Lifecycle.ViewModelSavedState => 0xd841015ed86f6aab => 63
	i64 15609085926864131306, ; 194: System.dll => 0xd89e9cf3334914ea => 109
	i64 15661133872274321916, ; 195: System.Xml.ReaderWriter.dll => 0xd9578647d4bfb1fc => 108
	i64 15783653065526199428, ; 196: el\Microsoft.Maui.Controls.resources => 0xdb0accd674b1c484 => 5
	i64 16056281320585338352, ; 197: ru\Microsoft.Maui.Controls.resources.dll => 0xded35eca8f3a9df0 => 24
	i64 16154507427712707110, ; 198: System => 0xe03056ea4e39aa26 => 109
	i64 16288847719894691167, ; 199: nb\Microsoft.Maui.Controls.resources => 0xe20d9cb300c12d5f => 18
	i64 16321164108206115771, ; 200: Microsoft.Extensions.Logging.Abstractions.dll => 0xe2806c487e7b0bbb => 41
	i64 16649148416072044166, ; 201: Microsoft.Maui.Graphics => 0xe70da84600bb4e86 => 48
	i64 16677317093839702854, ; 202: Xamarin.AndroidX.Navigation.UI => 0xe771bb8960dd8b46 => 68
	i64 16803648858859583026, ; 203: ms\Microsoft.Maui.Controls.resources.dll => 0xe9328d9b8ab93632 => 17
	i64 16890310621557459193, ; 204: System.Text.RegularExpressions.dll => 0xea66700587f088f9 => 104
	i64 16942731696432749159, ; 205: sk\Microsoft.Maui.Controls.resources => 0xeb20acb622a01a67 => 25
	i64 16998075588627545693, ; 206: Xamarin.AndroidX.Navigation.Fragment => 0xebe54bb02d623e5d => 66
	i64 17008137082415910100, ; 207: System.Collections.NonGeneric => 0xec090a90408c8cd4 => 79
	i64 17031351772568316411, ; 208: Xamarin.AndroidX.Navigation.Common.dll => 0xec5b843380a769fb => 65
	i64 17062143951396181894, ; 209: System.ComponentModel.Primitives => 0xecc8e986518c9786 => 81
	i64 17203614576212522419, ; 210: pl\Microsoft.Maui.Controls.resources.dll => 0xeebf844ef3e135b3 => 20
	i64 17310278548634113468, ; 211: hi\Microsoft.Maui.Controls.resources.dll => 0xf03a76a04e6695bc => 10
	i64 17342750010158924305, ; 212: hi\Microsoft.Maui.Controls.resources => 0xf0add33f97ecc211 => 10
	i64 17514990004910432069, ; 213: fr\Microsoft.Maui.Controls.resources => 0xf311be9c6f341f45 => 8
	i64 17623389608345532001, ; 214: pl\Microsoft.Maui.Controls.resources => 0xf492db79dfbef661 => 20
	i64 17704177640604968747, ; 215: Xamarin.AndroidX.Loader => 0xf5b1dfc36cac272b => 64
	i64 17710060891934109755, ; 216: Xamarin.AndroidX.Lifecycle.ViewModel => 0xf5c6c68c9e45303b => 62
	i64 17712670374920797664, ; 217: System.Runtime.InteropServices.dll => 0xf5d00bdc38bd3de0 => 99
	i64 17827813215687577648, ; 218: hr\Microsoft.Maui.Controls.resources.dll => 0xf7691da9f3129030 => 11
	i64 17942426894774770628, ; 219: de\Microsoft.Maui.Controls.resources.dll => 0xf9004e329f771bc4 => 4
	i64 18025913125965088385, ; 220: System.Threading => 0xfa28e87b91334681 => 107
	i64 18121036031235206392, ; 221: Xamarin.AndroidX.Navigation.Common => 0xfb7ada42d3d42cf8 => 65
	i64 18225059387460068507, ; 222: System.Threading.ThreadPool.dll => 0xfcec6af3cff4a49b => 106
	i64 18245806341561545090, ; 223: System.Collections.Concurrent.dll => 0xfd3620327d587182 => 78
	i64 18305135509493619199, ; 224: Xamarin.AndroidX.Navigation.Runtime.dll => 0xfe08e7c2d8c199ff => 67
	i64 18324163916253801303, ; 225: it\Microsoft.Maui.Controls.resources => 0xfe4c81ff0a56ab57 => 14
	i64 18342408478508122430, ; 226: id\Microsoft.Maui.Controls.resources.dll => 0xfe8d53543697013e => 13
	i64 18358161419737137786 ; 227: he\Microsoft.Maui.Controls.resources.dll => 0xfec54a8ba8b6827a => 9
], align 16

@assembly_image_cache_indices = dso_local local_unnamed_addr constant [228 x i32] [
	i32 43, ; 0
	i32 113, ; 1
	i32 47, ; 2
	i32 89, ; 3
	i32 53, ; 4
	i32 70, ; 5
	i32 105, ; 6
	i32 83, ; 7
	i32 12, ; 8
	i32 58, ; 9
	i32 74, ; 10
	i32 66, ; 11
	i32 93, ; 12
	i32 44, ; 13
	i32 112, ; 14
	i32 105, ; 15
	i32 51, ; 16
	i32 63, ; 17
	i32 91, ; 18
	i32 97, ; 19
	i32 50, ; 20
	i32 6, ; 21
	i32 70, ; 22
	i32 28, ; 23
	i32 45, ; 24
	i32 62, ; 25
	i32 58, ; 26
	i32 78, ; 27
	i32 61, ; 28
	i32 102, ; 29
	i32 54, ; 30
	i32 100, ; 31
	i32 49, ; 32
	i32 27, ; 33
	i32 38, ; 34
	i32 2, ; 35
	i32 7, ; 36
	i32 74, ; 37
	i32 60, ; 38
	i32 95, ; 39
	i32 76, ; 40
	i32 47, ; 41
	i32 77, ; 42
	i32 36, ; 43
	i32 71, ; 44
	i32 110, ; 45
	i32 22, ; 46
	i32 100, ; 47
	i32 37, ; 48
	i32 108, ; 49
	i32 36, ; 50
	i32 69, ; 51
	i32 40, ; 52
	i32 45, ; 53
	i32 94, ; 54
	i32 91, ; 55
	i32 3, ; 56
	i32 98, ; 57
	i32 33, ; 58
	i32 83, ; 59
	i32 106, ; 60
	i32 89, ; 61
	i32 82, ; 62
	i32 28, ; 63
	i32 35, ; 64
	i32 49, ; 65
	i32 71, ; 66
	i32 18, ; 67
	i32 26, ; 68
	i32 26, ; 69
	i32 29, ; 70
	i32 87, ; 71
	i32 101, ; 72
	i32 73, ; 73
	i32 23, ; 74
	i32 103, ; 75
	i32 6, ; 76
	i32 34, ; 77
	i32 61, ; 78
	i32 77, ; 79
	i32 7, ; 80
	i32 11, ; 81
	i32 57, ; 82
	i32 42, ; 83
	i32 19, ; 84
	i32 86, ; 85
	i32 95, ; 86
	i32 90, ; 87
	i32 82, ; 88
	i32 96, ; 89
	i32 92, ; 90
	i32 110, ; 91
	i32 75, ; 92
	i32 14, ; 93
	i32 51, ; 94
	i32 25, ; 95
	i32 80, ; 96
	i32 60, ; 97
	i32 85, ; 98
	i32 16, ; 99
	i32 111, ; 100
	i32 80, ; 101
	i32 48, ; 102
	i32 101, ; 103
	i32 31, ; 104
	i32 68, ; 105
	i32 97, ; 106
	i32 111, ; 107
	i32 67, ; 108
	i32 21, ; 109
	i32 85, ; 110
	i32 31, ; 111
	i32 73, ; 112
	i32 50, ; 113
	i32 5, ; 114
	i32 29, ; 115
	i32 104, ; 116
	i32 54, ; 117
	i32 79, ; 118
	i32 1, ; 119
	i32 113, ; 120
	i32 46, ; 121
	i32 92, ; 122
	i32 98, ; 123
	i32 44, ; 124
	i32 3, ; 125
	i32 19, ; 126
	i32 57, ; 127
	i32 76, ; 128
	i32 55, ; 129
	i32 1, ; 130
	i32 33, ; 131
	i32 93, ; 132
	i32 41, ; 133
	i32 46, ; 134
	i32 12, ; 135
	i32 27, ; 136
	i32 8, ; 137
	i32 72, ; 138
	i32 15, ; 139
	i32 42, ; 140
	i32 56, ; 141
	i32 99, ; 142
	i32 13, ; 143
	i32 72, ; 144
	i32 40, ; 145
	i32 30, ; 146
	i32 103, ; 147
	i32 59, ; 148
	i32 64, ; 149
	i32 34, ; 150
	i32 86, ; 151
	i32 52, ; 152
	i32 88, ; 153
	i32 53, ; 154
	i32 43, ; 155
	i32 0, ; 156
	i32 21, ; 157
	i32 112, ; 158
	i32 9, ; 159
	i32 75, ; 160
	i32 30, ; 161
	i32 69, ; 162
	i32 81, ; 163
	i32 84, ; 164
	i32 59, ; 165
	i32 35, ; 166
	i32 52, ; 167
	i32 107, ; 168
	i32 23, ; 169
	i32 94, ; 170
	i32 24, ; 171
	i32 32, ; 172
	i32 102, ; 173
	i32 2, ; 174
	i32 38, ; 175
	i32 16, ; 176
	i32 15, ; 177
	i32 32, ; 178
	i32 56, ; 179
	i32 0, ; 180
	i32 39, ; 181
	i32 88, ; 182
	i32 96, ; 183
	i32 17, ; 184
	i32 87, ; 185
	i32 90, ; 186
	i32 22, ; 187
	i32 37, ; 188
	i32 55, ; 189
	i32 39, ; 190
	i32 84, ; 191
	i32 4, ; 192
	i32 63, ; 193
	i32 109, ; 194
	i32 108, ; 195
	i32 5, ; 196
	i32 24, ; 197
	i32 109, ; 198
	i32 18, ; 199
	i32 41, ; 200
	i32 48, ; 201
	i32 68, ; 202
	i32 17, ; 203
	i32 104, ; 204
	i32 25, ; 205
	i32 66, ; 206
	i32 79, ; 207
	i32 65, ; 208
	i32 81, ; 209
	i32 20, ; 210
	i32 10, ; 211
	i32 10, ; 212
	i32 8, ; 213
	i32 20, ; 214
	i32 64, ; 215
	i32 62, ; 216
	i32 99, ; 217
	i32 11, ; 218
	i32 4, ; 219
	i32 107, ; 220
	i32 65, ; 221
	i32 106, ; 222
	i32 78, ; 223
	i32 67, ; 224
	i32 14, ; 225
	i32 13, ; 226
	i32 9 ; 227
], align 16

@marshal_methods_number_of_classes = dso_local local_unnamed_addr constant i32 0, align 4

@marshal_methods_class_cache = dso_local local_unnamed_addr global [0 x %struct.MarshalMethodsManagedClass] zeroinitializer, align 8

; Names of classes in which marshal methods reside
@mm_class_names = dso_local local_unnamed_addr constant [0 x ptr] zeroinitializer, align 8

@mm_method_names = dso_local local_unnamed_addr constant [1 x %struct.MarshalMethodName] [
	%struct.MarshalMethodName {
		i64 0, ; id 0x0; name: 
		ptr @.MarshalMethodName.0_name; char* name
	} ; 0
], align 8

; get_function_pointer (uint32_t mono_image_index, uint32_t class_index, uint32_t method_token, void*& target_ptr)
@get_function_pointer = internal dso_local unnamed_addr global ptr null, align 8

; Functions

; Function attributes: "min-legal-vector-width"="0" mustprogress nofree norecurse nosync "no-trapping-math"="true" nounwind "stack-protector-buffer-size"="8" uwtable willreturn
define void @xamarin_app_init(ptr nocapture noundef readnone %env, ptr noundef %fn) local_unnamed_addr #0
{
	%fnIsNull = icmp eq ptr %fn, null
	br i1 %fnIsNull, label %1, label %2

1: ; preds = %0
	%putsResult = call noundef i32 @puts(ptr @.str.0)
	call void @abort()
	unreachable 

2: ; preds = %1, %0
	store ptr %fn, ptr @get_function_pointer, align 8, !tbaa !3
	ret void
}

; Strings
@.str.0 = private unnamed_addr constant [40 x i8] c"get_function_pointer MUST be specified\0A\00", align 16

;MarshalMethodName
@.MarshalMethodName.0_name = private unnamed_addr constant [1 x i8] c"\00", align 1

; External functions

; Function attributes: noreturn "no-trapping-math"="true" nounwind "stack-protector-buffer-size"="8"
declare void @abort() local_unnamed_addr #2

; Function attributes: nofree nounwind
declare noundef i32 @puts(ptr noundef) local_unnamed_addr #1
attributes #0 = { "min-legal-vector-width"="0" mustprogress nofree norecurse nosync "no-trapping-math"="true" nounwind "stack-protector-buffer-size"="8" "target-cpu"="x86-64" "target-features"="+crc32,+cx16,+cx8,+fxsr,+mmx,+popcnt,+sse,+sse2,+sse3,+sse4.1,+sse4.2,+ssse3,+x87" "tune-cpu"="generic" uwtable willreturn }
attributes #1 = { nofree nounwind }
attributes #2 = { noreturn "no-trapping-math"="true" nounwind "stack-protector-buffer-size"="8" "target-cpu"="x86-64" "target-features"="+crc32,+cx16,+cx8,+fxsr,+mmx,+popcnt,+sse,+sse2,+sse3,+sse4.1,+sse4.2,+ssse3,+x87" "tune-cpu"="generic" }

; Metadata
!llvm.module.flags = !{!0, !1}
!0 = !{i32 1, !"wchar_size", i32 4}
!1 = !{i32 7, !"PIC Level", i32 2}
!llvm.ident = !{!2}
!2 = !{!"Xamarin.Android remotes/origin/release/8.0.1xx @ af27162bee43b7fecdca59b4f67aa8c175cbc875"}
!3 = !{!4, !4, i64 0}
!4 = !{!"any pointer", !5, i64 0}
!5 = !{!"omnipotent char", !6, i64 0}
!6 = !{!"Simple C++ TBAA"}
