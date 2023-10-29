Imports System.Security.Cryptography
Imports System.Windows
Imports TTB.ClsBitcoinTransaction
Imports TTB.Form1
Imports TTB.Secp256k1Vb

Public Class Form1

#Region "Properties"

    Public Property G_Transaction As S_Transaction

    Property WordCNT As Integer = 2048
    Property Words As List(Of String) = New List(Of String)({"abandon", "ability", "able", "about", "above", "absent", "absorb", "abstract", "absurd", "abuse", "access", "accident", "account", "accuse", "achieve", "acid", "acoustic", "acquire", "across", "act", "action", "actor", "actress", "actual", "adapt", "add", "addict", "address", "adjust", "admit", "adult", "advance", "advice", "aerobic", "affair", "afford", "afraid", "again", "age", "agent", "agree", "ahead", "aim", "air", "airport", "aisle", "alarm", "album", "alcohol", "alert", "alien", "all", "alley", "allow", "almost", "alone", "alpha", "already", "also", "alter", "always", "amateur", "amazing", "among", "amount", "amused", "analyst", "anchor", "ancient", "anger", "angle", "angry", "animal", "ankle", "announce", "annual", "another", "answer", "antenna", "antique", "anxiety", "any", "apart", "apology", "appear", "apple", "approve", "april", "arch", "arctic", "area", "arena", "argue", "arm", "armed", "armor", "army", "around", "arrange", "arrest", "arrive", "arrow", "art", "artefact", "artist", "artwork", "ask", "aspect", "assault", "asset", "assist", "assume", "asthma", "athlete", "atom", "attack", "attend", "attitude", "attract", "auction", "audit", "august", "aunt", "author", "auto", "autumn", "average", "avocado", "avoid", "awake", "aware", "away", "awesome", "awful", "awkward", "axis", "baby", "bachelor", "bacon", "badge", "bag", "balance", "balcony", "ball", "bamboo", "banana", "banner", "bar", "barely", "bargain", "barrel", "base", "basic", "basket", "battle", "beach", "bean", "beauty", "because", "become", "beef", "before", "begin", "behave", "behind", "believe", "below", "belt", "bench", "benefit", "best", "betray", "better", "between", "beyond", "bicycle", "bid", "bike", "bind", "biology", "bird", "birth", "bitter", "black", "blade", "blame", "blanket", "blast", "bleak", "bless", "blind", "blood", "blossom", "blouse", "blue", "blur", "blush", "board", "boat", "body", "boil", "bomb", "bone", "bonus", "book", "boost", "border", "boring", "borrow", "boss", "bottom", "bounce", "box", "boy", "bracket", "brain", "brand", "brass", "brave", "bread", "breeze", "brick", "bridge", "brief", "bright", "bring", "brisk", "broccoli", "broken", "bronze", "broom", "brother", "brown", "brush", "bubble", "buddy", "budget", "buffalo", "build", "bulb", "bulk", "bullet", "bundle", "bunker", "burden", "burger", "burst", "bus", "business", "busy", "butter", "buyer", "buzz", "cabbage", "cabin", "cable", "cactus", "cage", "cake", "call", "calm", "camera", "camp", "can", "canal", "cancel", "candy", "cannon", "canoe", "canvas", "canyon", "capable", "capital", "captain", "car", "carbon", "card", "cargo", "carpet", "carry", "cart", "case", "cash", "casino", "castle", "casual", "cat", "catalog", "catch", "category", "cattle", "caught", "cause", "caution", "cave", "ceiling", "celery", "cement", "census", "century", "cereal", "certain", "chair", "chalk", "champion", "change", "chaos", "chapter", "charge", "chase", "chat", "cheap", "check", "cheese", "chef", "cherry", "chest", "chicken", "chief", "child", "chimney", "choice", "choose", "chronic", "chuckle", "chunk", "churn", "cigar", "cinnamon", "circle", "citizen", "city", "civil", "claim", "clap", "clarify", "claw", "clay", "clean", "clerk", "clever", "click", "client", "cliff", "climb", "clinic", "clip", "clock", "clog", "close", "cloth", "cloud", "clown", "club", "clump", "cluster", "clutch", "coach", "coast", "coconut", "code", "coffee", "coil", "coin", "collect", "color", "column", "combine", "come", "comfort", "comic", "common", "company", "concert", "conduct", "confirm", "congress", "connect", "consider", "control", "convince", "cook", "cool", "copper", "copy", "coral", "core", "corn", "correct", "cost", "cotton", "couch", "country", "couple", "course", "cousin", "cover", "coyote", "crack", "cradle", "craft", "cram", "crane", "crash", "crater", "crawl", "crazy", "cream", "credit", "creek", "crew", "cricket", "crime", "crisp", "critic", "crop", "cross", "crouch", "crowd", "crucial", "cruel", "cruise", "crumble", "crunch", "crush", "cry", "crystal", "cube", "culture", "cup", "cupboard", "curious", "current", "curtain", "curve", "cushion", "custom", "cute", "cycle", "dad", "damage", "damp", "dance", "danger", "daring", "dash", "daughter", "dawn", "day", "deal", "debate", "debris", "decade", "december", "decide", "decline", "decorate", "decrease", "deer", "defense", "define", "defy", "degree", "delay", "deliver", "demand", "demise", "denial", "dentist", "deny", "depart", "depend", "deposit", "depth", "deputy", "derive", "describe", "desert", "design", "desk", "despair", "destroy", "detail", "detect", "develop", "device", "devote", "diagram", "dial", "diamond", "diary", "dice", "diesel", "diet", "differ", "digital", "dignity", "dilemma", "dinner", "dinosaur", "direct", "dirt", "disagree", "discover", "disease", "dish", "dismiss", "disorder", "display", "distance", "divert", "divide", "divorce", "dizzy", "doctor", "document", "dog", "doll", "dolphin", "domain", "donate", "donkey", "donor", "door", "dose", "double", "dove", "draft", "dragon", "drama", "drastic", "draw", "dream", "dress", "drift", "drill", "drink", "drip", "drive", "drop", "drum", "dry", "duck", "dumb", "dune", "during", "dust", "dutch", "duty", "dwarf", "dynamic", "eager", "eagle", "early", "earn", "earth", "easily", "east", "easy", "echo", "ecology", "economy", "edge", "edit", "educate", "effort", "egg", "eight", "either", "elbow", "elder", "electric", "elegant", "element", "elephant", "elevator", "elite", "else", "embark", "embody", "embrace", "emerge", "emotion", "employ", "empower", "empty", "enable", "enact", "end", "endless", "endorse", "enemy", "energy", "enforce", "engage", "engine", "enhance", "enjoy", "enlist", "enough", "enrich", "enroll", "ensure", "enter", "entire", "entry", "envelope", "episode", "equal", "equip", "era", "erase", "erode", "erosion", "error", "erupt", "escape", "essay", "essence", "estate", "eternal", "ethics", "evidence", "evil", "evoke", "evolve", "exact", "example", "excess", "exchange", "excite", "exclude", "excuse", "execute", "exercise", "exhaust", "exhibit", "exile", "exist", "exit", "exotic", "expand", "expect", "expire", "explain", "expose", "express", "extend", "extra", "eye", "eyebrow", "fabric", "face", "faculty", "fade", "faint", "faith", "fall", "false", "fame", "family", "famous", "fan", "fancy", "fantasy", "farm", "fashion", "fat", "fatal", "father", "fatigue", "fault", "favorite", "feature", "february", "federal", "fee", "feed", "feel", "female", "fence", "festival", "fetch", "fever", "few", "fiber", "fiction", "field", "figure", "file", "film", "filter", "final", "find", "fine", "finger", "finish", "fire", "firm", "first", "fiscal", "fish", "fit", "fitness", "fix", "flag", "flame", "flash", "flat", "flavor", "flee", "flight", "flip", "float", "flock", "floor", "flower", "fluid", "flush", "fly", "foam", "focus", "fog", "foil", "fold", "follow", "food", "foot", "force", "forest", "forget", "fork", "fortune", "forum", "forward", "fossil", "foster", "found", "fox", "fragile", "frame", "frequent", "fresh", "friend", "fringe", "frog", "front", "frost", "frown", "frozen", "fruit", "fuel", "fun", "funny", "furnace", "fury", "future", "gadget", "gain", "galaxy", "gallery", "game", "gap", "garage", "garbage", "garden", "garlic", "garment", "gas", "gasp", "gate", "gather", "gauge", "gaze", "general", "genius", "genre", "gentle", "genuine", "gesture", "ghost", "giant", "gift", "giggle", "ginger", "giraffe", "girl", "give", "glad", "glance", "glare", "glass", "glide", "glimpse", "globe", "gloom", "glory", "glove", "glow", "glue", "goat", "goddess", "gold", "good", "goose", "gorilla", "gospel", "gossip", "govern", "gown", "grab", "grace", "grain", "grant", "grape", "grass", "gravity", "great", "green", "grid", "grief", "grit", "grocery", "group", "grow", "grunt", "guard", "guess", "guide", "guilt", "guitar", "gun", "gym", "habit", "hair", "half", "hammer", "hamster", "hand", "happy", "harbor", "hard", "harsh", "harvest", "hat", "have", "hawk", "hazard", "head", "health", "heart", "heavy", "hedgehog", "height", "hello", "helmet", "help", "hen", "hero", "hidden", "high", "hill", "hint", "hip", "hire", "history", "hobby", "hockey", "hold", "hole", "holiday", "hollow", "home", "honey", "hood", "hope", "horn", "horror", "horse", "hospital", "host", "hotel", "hour", "hover", "hub", "huge", "human", "humble", "humor", "hundred", "hungry", "hunt", "hurdle", "hurry", "hurt", "husband", "hybrid", "ice", "icon", "idea", "identify", "idle", "ignore", "ill", "illegal", "illness", "image", "imitate", "immense", "immune", "impact", "impose", "improve", "impulse", "inch", "include", "income", "increase", "index", "indicate", "indoor", "industry", "infant", "inflict", "inform", "inhale", "inherit", "initial", "inject", "injury", "inmate", "inner", "innocent", "input", "inquiry", "insane", "insect", "inside", "inspire", "install", "intact", "interest", "into", "invest", "invite", "involve", "iron", "island", "isolate", "issue", "item", "ivory", "jacket", "jaguar", "jar", "jazz", "jealous", "jeans", "jelly", "jewel", "job", "join", "joke", "journey", "joy", "judge", "juice", "jump", "jungle", "junior", "junk", "just", "kangaroo", "keen", "keep", "ketchup", "key", "kick", "kid", "kidney", "kind", "kingdom", "kiss", "kit", "kitchen", "kite", "kitten", "kiwi", "knee", "knife", "knock", "know", "lab", "label", "labor", "ladder", "lady", "lake", "lamp", "language", "laptop", "large", "later", "latin", "laugh", "laundry", "lava", "law", "lawn", "lawsuit", "layer", "lazy", "leader", "leaf", "learn", "leave", "lecture", "left", "leg", "legal", "legend", "leisure", "lemon", "lend", "length", "lens", "leopard", "lesson", "letter", "level", "liar", "liberty", "library", "license", "life", "lift", "light", "like", "limb", "limit", "link", "lion", "liquid", "list", "little", "live", "lizard", "load", "loan", "lobster", "local", "lock", "logic", "lonely", "long", "loop", "lottery", "loud", "lounge", "love", "loyal", "lucky", "luggage", "lumber", "lunar", "lunch", "luxury", "lyrics", "machine", "mad", "magic", "magnet", "maid", "mail", "main", "major", "make", "mammal", "man", "manage", "mandate", "mango", "mansion", "manual", "maple", "marble", "march", "margin", "marine", "market", "marriage", "mask", "mass", "master", "match", "material", "math", "matrix", "matter", "maximum", "maze", "meadow", "mean", "measure", "meat", "mechanic", "medal", "media", "melody", "melt", "member", "memory", "mention", "menu", "mercy", "merge", "merit", "merry", "mesh", "message", "metal", "method", "middle", "midnight", "milk", "million", "mimic", "mind", "minimum", "minor", "minute", "miracle", "mirror", "misery", "miss", "mistake", "mix", "mixed", "mixture", "mobile", "model", "modify", "mom", "moment", "monitor", "monkey", "monster", "month", "moon", "moral", "more", "morning", "mosquito", "mother", "motion", "motor", "mountain", "mouse", "move", "movie", "much", "muffin", "mule", "multiply", "muscle", "museum", "mushroom", "music", "must", "mutual", "myself", "mystery", "myth", "naive", "name", "napkin", "narrow", "nasty", "nation", "nature", "near", "neck", "need", "negative", "neglect", "neither", "nephew", "nerve", "nest", "net", "network", "neutral", "never", "news", "next", "nice", "night", "noble", "noise", "nominee", "noodle", "normal", "north", "nose", "notable", "note", "nothing", "notice", "novel", "now", "nuclear", "number", "nurse", "nut", "oak", "obey", "object", "oblige", "obscure", "observe", "obtain", "obvious", "occur", "ocean", "october", "odor", "off", "offer", "office", "often", "oil", "okay", "old", "olive", "olympic", "omit", "once", "one", "onion", "online", "only", "open", "opera", "opinion", "oppose", "option", "orange", "orbit", "orchard", "order", "ordinary", "organ", "orient", "original", "orphan", "ostrich", "other", "outdoor", "outer", "output", "outside", "oval", "oven", "over", "own", "owner", "oxygen", "oyster", "ozone", "pact", "paddle", "page", "pair", "palace", "palm", "panda", "panel", "panic", "panther", "paper", "parade", "parent", "park", "parrot", "party", "pass", "patch", "path", "patient", "patrol", "pattern", "pause", "pave", "payment", "peace", "peanut", "pear", "peasant", "pelican", "pen", "penalty", "pencil", "people", "pepper", "perfect", "permit", "person", "pet", "phone", "photo", "phrase", "physical", "piano", "picnic", "picture", "piece", "pig", "pigeon", "pill", "pilot", "pink", "pioneer", "pipe", "pistol", "pitch", "pizza", "place", "planet", "plastic", "plate", "play", "please", "pledge", "pluck", "plug", "plunge", "poem", "poet", "point", "polar", "pole", "police", "pond", "pony", "pool", "popular", "portion", "position", "possible", "post", "potato", "pottery", "poverty", "powder", "power", "practice", "praise", "predict", "prefer", "prepare", "present", "pretty", "prevent", "price", "pride", "primary", "print", "priority", "prison", "private", "prize", "problem", "process", "produce", "profit", "program", "project", "promote", "proof", "property", "prosper", "protect", "proud", "provide", "public", "pudding", "pull", "pulp", "pulse", "pumpkin", "punch", "pupil", "puppy", "purchase", "purity", "purpose", "purse", "push", "put", "puzzle", "pyramid", "quality", "quantum", "quarter", "question", "quick", "quit", "quiz", "quote", "rabbit", "raccoon", "race", "rack", "radar", "radio", "rail", "rain", "raise", "rally", "ramp", "ranch", "random", "range", "rapid", "rare", "rate", "rather", "raven", "raw", "razor", "ready", "real", "reason", "rebel", "rebuild", "recall", "receive", "recipe", "record", "recycle", "reduce", "reflect", "reform", "refuse", "region", "regret", "regular", "reject", "relax", "release", "relief", "rely", "remain", "remember", "remind", "remove", "render", "renew", "rent", "reopen", "repair", "repeat", "replace", "report", "require", "rescue", "resemble", "resist", "resource", "response", "result", "retire", "retreat", "return", "reunion", "reveal", "review", "reward", "rhythm", "rib", "ribbon", "rice", "rich", "ride", "ridge", "rifle", "right", "rigid", "ring", "riot", "ripple", "risk", "ritual", "rival", "river", "road", "roast", "robot", "robust", "rocket", "romance", "roof", "rookie", "room", "rose", "rotate", "rough", "round", "route", "royal", "rubber", "rude", "rug", "rule", "run", "runway", "rural", "sad", "saddle", "sadness", "safe", "sail", "salad", "salmon", "salon", "salt", "salute", "same", "sample", "sand", "satisfy", "satoshi", "sauce", "sausage", "save", "say", "scale", "scan", "scare", "scatter", "scene", "scheme", "school", "science", "scissors", "scorpion", "scout", "scrap", "screen", "script", "scrub", "sea", "search", "season", "seat", "second", "secret", "section", "security", "seed", "seek", "segment", "select", "sell", "seminar", "senior", "sense", "sentence", "series", "service", "session", "settle", "setup", "seven", "shadow", "shaft", "shallow", "share", "shed", "shell", "sheriff", "shield", "shift", "shine", "ship", "shiver", "shock", "shoe", "shoot", "shop", "short", "shoulder", "shove", "shrimp", "shrug", "shuffle", "shy", "sibling", "sick", "side", "siege", "sight", "sign", "silent", "silk", "silly", "silver", "similar", "simple", "since", "sing", "siren", "sister", "situate", "six", "size", "skate", "sketch", "ski", "skill", "skin", "skirt", "skull", "slab", "slam", "sleep", "slender", "slice", "slide", "slight", "slim", "slogan", "slot", "slow", "slush", "small", "smart", "smile", "smoke", "smooth", "snack", "snake", "snap", "sniff", "snow", "soap", "soccer", "social", "sock", "soda", "soft", "solar", "soldier", "solid", "solution", "solve", "someone", "song", "soon", "sorry", "sort", "soul", "sound", "soup", "source", "south", "space", "spare", "spatial", "spawn", "speak", "special", "speed", "spell", "spend", "sphere", "spice", "spider", "spike", "spin", "spirit", "split", "spoil", "sponsor", "spoon", "sport", "spot", "spray", "spread", "spring", "spy", "square", "squeeze", "squirrel", "stable", "stadium", "staff", "stage", "stairs", "stamp", "stand", "start", "state", "stay", "steak", "steel", "stem", "step", "stereo", "stick", "still", "sting", "stock", "stomach", "stone", "stool", "story", "stove", "strategy", "street", "strike", "strong", "struggle", "student", "stuff", "stumble", "style", "subject", "submit", "subway", "success", "such", "sudden", "suffer", "sugar", "suggest", "suit", "summer", "sun", "sunny", "sunset", "super", "supply", "supreme", "sure", "surface", "surge", "surprise", "surround", "survey", "suspect", "sustain", "swallow", "swamp", "swap", "swarm", "swear", "sweet", "swift", "swim", "swing", "switch", "sword", "symbol", "symptom", "syrup", "system", "table", "tackle", "tag", "tail", "talent", "talk", "tank", "tape", "target", "task", "taste", "tattoo", "taxi", "teach", "team", "tell", "ten", "tenant", "tennis", "tent", "term", "test", "text", "thank", "that", "theme", "then", "theory", "there", "they", "thing", "this", "thought", "three", "thrive", "throw", "thumb", "thunder", "ticket", "tide", "tiger", "tilt", "timber", "time", "tiny", "tip", "tired", "tissue", "title", "toast", "tobacco", "today", "toddler", "toe", "together", "toilet", "token", "tomato", "tomorrow", "tone", "tongue", "tonight", "tool", "tooth", "top", "topic", "topple", "torch", "tornado", "tortoise", "toss", "total", "tourist", "toward", "tower", "town", "toy", "track", "trade", "traffic", "tragic", "train", "transfer", "trap", "trash", "travel", "tray", "treat", "tree", "trend", "trial", "tribe", "trick", "trigger", "trim", "trip", "trophy", "trouble", "truck", "true", "truly", "trumpet", "trust", "truth", "try", "tube", "tuition", "tumble", "tuna", "tunnel", "turkey", "turn", "turtle", "twelve", "twenty", "twice", "twin", "twist", "two", "type", "typical", "ugly", "umbrella", "unable", "unaware", "uncle", "uncover", "under", "undo", "unfair", "unfold", "unhappy", "uniform", "unique", "unit", "universe", "unknown", "unlock", "until", "unusual", "unveil", "update", "upgrade", "uphold", "upon", "upper", "upset", "urban", "urge", "usage", "use", "used", "useful", "useless", "usual", "utility", "vacant", "vacuum", "vague", "valid", "valley", "valve", "van", "vanish", "vapor", "various", "vast", "vault", "vehicle", "velvet", "vendor", "venture", "venue", "verb", "verify", "version", "very", "vessel", "veteran", "viable", "vibrant", "vicious", "victory", "video", "view", "village", "vintage", "violin", "virtual", "virus", "visa", "visit", "visual", "vital", "vivid", "vocal", "voice", "void", "volcano", "volume", "vote", "voyage", "wage", "wagon", "wait", "walk", "wall", "walnut", "want", "warfare", "warm", "warrior", "wash", "wasp", "waste", "water", "wave", "way", "wealth", "weapon", "wear", "weasel", "weather", "web", "wedding", "weekend", "weird", "welcome", "west", "wet", "whale", "what", "wheat", "wheel", "when", "where", "whip", "whisper", "wide", "width", "wife", "wild", "will", "win", "window", "wine", "wing", "wink", "winner", "winter", "wire", "wisdom", "wise", "wish", "witness", "wolf", "woman", "wonder", "wood", "wool", "word", "work", "world", "worry", "worth", "wrap", "wreck", "wrestle", "wrist", "write", "wrong", "yard", "year", "yellow", "you", "young", "youth", "zebra", "zero", "zone", "zoo"})

#End Region

#Region "Structures"

    Public Structure S_Transaction
        Dim Version As String
        Dim NumberOfInputs As String
        Dim Inputs As List(Of S_Input)
        Dim NumberOfOutputs As String
        Dim Outputs As List(Of S_Output)
        Dim LockTime As String
        Dim HashCode As String

        Public Sub New(Optional ByVal init As String = "")
            Version = ""
            NumberOfInputs = ""
            Inputs = New List(Of S_Input)
            NumberOfOutputs = ""
            Outputs = New List(Of S_Output)
            LockTime = ""
            HashCode = ""
        End Sub
    End Structure

    Public Structure S_Input
        Dim Transaction As String
        Dim OutputIDX As String
        Dim ScriptLength As String
        Dim Script As String
        Dim InputScriptEntries As List(Of ClsScriptEntry)
        Dim Sequence As String

        Public Sub New(Optional ByVal init As String = "")
            Transaction = ""
            OutputIDX = ""
            ScriptLength = ""
            Script = ""
            InputScriptEntries = New List(Of ClsScriptEntry)
            Sequence = ""
        End Sub

    End Structure

    Public Structure S_Output
        Dim AmountNQT As String
        Dim ScriptLength As String
        Dim Script As String
        Dim OutputScriptEntries As List(Of ClsScriptEntry)

        Public Sub New(Optional ByVal init As String = "")
            AmountNQT = ""
            ScriptLength = ""
            Script = ""
            OutputScriptEntries = New List(Of ClsScriptEntry)
        End Sub

    End Structure

#End Region

#Region "Address - GUI"

    Private Sub Bt_generate_Click(sender As Object, e As EventArgs) Handles Bt_generate.Click

        Dim RandNum As New Random
        Dim Pass As String = ""

        If RB_Words.Checked Then
            Pass = GetPass(0, CInt(NUDLength.Value), RandNum.Next(0, CInt(NUDLength.Value)))
        Else
            Pass = GetPass(1, CInt(NUDLength.Value), RandNum.Next(0, CInt(NUDLength.Value)))
        End If

        TB_Mnemonic.Text = Pass
        Bt_generateFull.PerformClick()

    End Sub

    Private Function GetPass(ByVal FlipFlop As Integer, Optional ByVal Length As Integer = 12, Optional ByVal Salt As Integer = 0) As String

        Dim T_Pass As String = ""
        Dim RandNum As New Random

        For i As Integer = 0 To Length - 1

            Dim RandomInt As Integer = 0

            RandomInt += Salt

            If RandomInt > WordCNT Then
                RandomInt = RandomInt Mod WordCNT
            ElseIf RandomInt = WordCNT Then
                RandomInt -= 1
            End If

            If FlipFlop = 0 Then
                RandomInt = RandNum.Next(0, WordCNT)
                T_Pass += Words(RandomInt) + " "
            Else
                RandomInt = RandNum.Next(1, 62)
                T_Pass += GenRandomChar(RandomInt)
            End If

        Next

        Return T_Pass.Trim

    End Function

    Private Function GenRandomChar(ByVal Rand As Integer) As String

        Select Case Rand
            Case 1
                Return "0"
            Case 2
                Return "1"
            Case 3
                Return "2"
            Case 4
                Return "3"
            Case 5
                Return "4"
            Case 6
                Return "5"
            Case 7
                Return "6"
            Case 8
                Return "7"
            Case 9
                Return "8"
            Case 10
                Return "9"

            Case 11
                Return "A"
            Case 12
                Return "B"
            Case 13
                Return "C"
            Case 14
                Return "D"
            Case 15
                Return "E"
            Case 16
                Return "F"
            Case 17
                Return "G"
            Case 18
                Return "H"
            Case 19
                Return "I"
            Case 20
                Return "J"
            Case 21
                Return "K"
            Case 22
                Return "L"
            Case 23
                Return "M"
            Case 24
                Return "N"
            Case 25
                Return "O"
            Case 26
                Return "P"
            Case 27
                Return "Q"
            Case 28
                Return "R"
            Case 29
                Return "S"
            Case 30
                Return "T"
            Case 31
                Return "U"
            Case 32
                Return "V"
            Case 33
                Return "W"
            Case 34
                Return "X"
            Case 35
                Return "Y"
            Case 36
                Return "Z"


            Case 37
                Return "a"
            Case 38
                Return "b"
            Case 39
                Return "c"
            Case 40
                Return "d"
            Case 41
                Return "e"
            Case 42
                Return "f"
            Case 43
                Return "g"
            Case 44
                Return "h"
            Case 45
                Return "i"
            Case 46
                Return "j"
            Case 47
                Return "k"
            Case 48
                Return "l"
            Case 49
                Return "m"
            Case 50
                Return "n"
            Case 51
                Return "o"
            Case 52
                Return "p"
            Case 53
                Return "q"
            Case 54
                Return "r"
            Case 55
                Return "s"
            Case 56
                Return "t"
            Case 57
                Return "u"
            Case 58
                Return "v"
            Case 59
                Return "w"
            Case 60
                Return "x"
            Case 61
                Return "y"
            Case 62
                Return "z"

        End Select

        Return ""

    End Function

    Private Sub Bt_generateFull_Click(sender As Object, e As EventArgs) Handles Bt_generateFull.Click

        Secp256k1.Start()
        Dim PrivateKey As String = ByteArrayToHEXString(SHA256.HashMsg(TB_Mnemonic.Text))
        Dim PubKey As PublicKey = Secp256k1.CreatePublicKey(HEXStringToByteArray(PrivateKey))
        Dim PublicKeyStr As String = ByteArrayToHEXString(PubKey.Serialize(True))
        Dim RIPE160 As String = PubKeyToRipe160(PublicKeyStr)
        Dim Address As String = RIPE160ToAddress(RIPE160, BitcoinAddressPrefix)

        TB_PrivateKey.Text = PrivateKey
        TB_CompPubKey.Text = PublicKeyStr
        TB_RIPE160.Text = RIPE160
        TB_Address.Text = Address

    End Sub

    Private Sub Bt_showMnemonic_Click(sender As Object, e As EventArgs) Handles Bt_showMnemonic.Click

        If TB_Mnemonic.UseSystemPasswordChar Then
            TB_Mnemonic.UseSystemPasswordChar = False
            Bt_showMnemonic.Text = "hide"
        Else
            TB_Mnemonic.UseSystemPasswordChar = True
            Bt_showMnemonic.Text = "show"
        End If

    End Sub

    Private Sub Bt_showPrivateKey_Click(sender As Object, e As EventArgs) Handles Bt_showPrivateKey.Click

        If TB_PrivateKey.UseSystemPasswordChar Then
            TB_PrivateKey.UseSystemPasswordChar = False
            Bt_showPrivateKey.Text = "hide"
        Else
            TB_PrivateKey.UseSystemPasswordChar = True
            Bt_showPrivateKey.Text = "show"
        End If

    End Sub

    Private Sub Bt_convertToRIPE160Address_Click(sender As Object, e As EventArgs) Handles Bt_convertToRIPE160Address.Click

        If Not TB_CompPubKey.Text.Trim() = "" Then
            If MessageIsHEXString(TB_CompPubKey.Text.Trim()) Then

                Dim RIPE160 As String = PubKeyToRipe160(TB_CompPubKey.Text)
                Dim Address As String = RIPE160ToAddress(RIPE160, BitcoinAddressPrefix)

                TB_RIPE160.Text = RIPE160
                TB_Address.Text = Address

            End If
        End If

    End Sub

    Private Sub Bt_convertToAddress_Click(sender As Object, e As EventArgs) Handles Bt_convertToAddress.Click

        If Not TB_RIPE160.Text.Trim() = "" Then
            Dim Address As String = RIPE160ToAddress(TB_RIPE160.Text, BitcoinAddressPrefix)
            TB_Address.Text = Address
        End If

    End Sub

    Private Sub Bt_convertToRipe160_Click(sender As Object, e As EventArgs) Handles Bt_convertToRipe160.Click

        If Not TB_Address.Text.Trim() = "" Then
            Dim RIPE160 As String = AddressToRipe160(TB_Address.Text, False)
            TB_RIPE160.Text = RIPE160.Remove(RIPE160.Length - 8)
        End If

    End Sub

    Private Sub Bt_showChainSwapKey_Click(sender As Object, e As EventArgs) Handles Bt_showChainSwapKey.Click

        If TB_ChainSwapKey.UseSystemPasswordChar Then
            TB_ChainSwapKey.UseSystemPasswordChar = False
            Bt_showChainSwapKey.Text = "hide"
        Else
            TB_ChainSwapKey.UseSystemPasswordChar = True
            Bt_showChainSwapKey.Text = "show"
        End If

    End Sub

    Private Sub Bt_addToSignKeys_Click(sender As Object, e As EventArgs) Handles Bt_addToSignKeys.Click
        With LV_SignKeyPairs.Items.Add("*****")
            .SubItems.Add("*****")
            .SubItems.Add(TB_CompPubKey.Text)
            .Tag = TB_PrivateKey.Text + ";" + TB_ChainSwapKey.Text
        End With

        LV_SignKeyPairs.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent)

    End Sub

    Private Sub RB_Words_CheckedChanged(sender As Object, e As EventArgs) Handles RB_Words.CheckedChanged, RB_RandomChars.CheckedChanged

        If RB_Words.Checked Then
            NUDLength.Value = 24
        Else
            NUDLength.Value = 64
        End If

    End Sub

    Private Sub Bt_TXShowCheckedSecrets_Click(sender As Object, e As EventArgs) Handles Bt_TXShowCheckedSecrets.Click

        If Bt_TXShowCheckedSecrets.Text = "show checked secrets" Then
            ShowHideCheckedLVItems()
            Bt_TXShowCheckedSecrets.Text = "hide secrets"
        Else
            ShowHideCheckedLVItems(False)
            Bt_TXShowCheckedSecrets.Text = "show checked secrets"
        End If

    End Sub

    Private Sub Bt_RemoveSignKey_Click(sender As Object, e As EventArgs) Handles Bt_RemoveSignKey.Click

        'TODO: remove procedure

    End Sub

    Private Sub ShowHideCheckedLVItems(Optional ByVal show As Boolean = True)
        For i As Integer = 0 To LV_SignKeyPairs.Items.Count - 1

            Dim T_LVItem As ListViewItem = LV_SignKeyPairs.Items(i)

            If T_LVItem.Checked And show Then
                Dim SecretKeys As List(Of String) = T_LVItem.Tag.ToString().Split(";").ToList()
                T_LVItem.SubItems(0).Text = SecretKeys(0)
                T_LVItem.SubItems(1).Text = SecretKeys(1)
            Else
                T_LVItem.SubItems(0).Text = "*****"
                T_LVItem.SubItems(1).Text = "*****"
                T_LVItem.Checked = False
            End If

            LV_SignKeyPairs.Items(i) = T_LVItem

        Next

        LV_SignKeyPairs.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent)

    End Sub

#End Region

#Region "Transaction - GUI"

    Private Sub Bt_TXconvertUTX_Click(sender As Object, e As EventArgs) Handles Bt_TXconvertUTX.Click

        If TB_TXUnsignedTransactionBytes.Text.Trim() = "" Then
            Exit Sub
        End If

        If Not MessageIsHEXString(TB_TXUnsignedTransactionBytes.Text.Trim()) Then
            Exit Sub
        End If

        Dim TransactionHEX As String = ""
        TransactionHEX = TB_TXUnsignedTransactionBytes.Text

        'TransactionHEX = "0200000002aa2f998c3ad372e64e41ae280574b155fdc8a2918d5cc91f894143b555475b5b000000006a473044022014c67e75147cf48d1940e3d58d7bb41423c952855c9bc30a8b6fc90d7637b17e02203b53be6f4fa9749c9d9e5b0edcdd6a4068521d56af3d6c7677174799c1fb438601210227f524471e8a34f55715fe06ed554e3f3621c7007460d031ecef24d075569a18ffffffff10de72201813487c879ecb8322be7ff75e453a90470d1b06e890c5f75c0f4ddb000000006a4730440220727107b48d3e975f8b298b9078ec1d7ffe736713cd89fe6cc8a51f7c2e0ff29a02206494fb57bb3e80552b61e63e341a0c586316383291f81b82ffe96f526545756f01210227f524471e8a34f55715fe06ed554e3f3621c7007460d031ecef24d075569a18ffffffff02e02e0000000000001976a914f57a0b8ba144b133dd900a2f9e8bb59c8f6ebea388ac54310000000000001976a914ee1fa939aa9e66d3aa5d1f24f503063222e09a8088ac00000000"
        'TransactionHEX = "02000000015a23e2cd8fd1b129798955ece4965651f30f2360ed3db8e3af5b7a8f2aa872ad010000001976a914ee1fa939aa9e66d3aa5d1f24f503063222e09a8088acffffffff02e80300000000000017a914a97c29da24d1cf5d7e76bdf30c3b6304e5221b3c876c2d0000000000001976a9148562fc5e57b965f8a62deaafeee84a7fc457c1d688ac0000000001000000"


        G_Transaction = ConvertTXStrToTX(TransactionHEX)

#Region "set in LV"

        LV_Transaction.Items.Clear()

        With LV_Transaction.Items.Add("Version")
            .SubItems.Add(G_Transaction.Version)
        End With

        With LV_Transaction.Items.Add("Inputs")
            .SubItems.Add(G_Transaction.NumberOfInputs)
        End With

        Dim NumberOfInputs As ULong = HEXStringToULongList(G_Transaction.NumberOfInputs)(0)
        For i As ULong = 0UL To NumberOfInputs - 1UL

            If G_Transaction.Inputs(i).InputScriptEntries(0).Key = ClsScriptEntry.E_OP_Code.Signature And G_Transaction.Inputs(i).InputScriptEntries(0).ValueHex = "01" Then
                Label11.Enabled = False
                Bt_TXsignTransaction.Enabled = False
            Else
                Label11.Enabled = True
                Bt_TXsignTransaction.Enabled = True
            End If

            Dim TXInput As ClsUnspentOutput = New ClsUnspentOutput()

            With LV_Transaction.Items.Add("Input" + i.ToString())
                .SubItems.Add(G_Transaction.Inputs(i).Transaction)
            End With

            With LV_Transaction.Items.Add("OutputIDXOfInput" + i.ToString())
                .SubItems.Add(G_Transaction.Inputs(i).OutputIDX.ToString())
            End With

            With LV_Transaction.Items.Add("ScriptLengthOfInput" + i.ToString())
                .SubItems.Add(G_Transaction.Inputs(i).ScriptLength)
            End With

            With LV_Transaction.Items.Add("ScriptOfInput" + i.ToString())
                .SubItems.Add(G_Transaction.Inputs(i).Script)
            End With

            With LV_Transaction.Items.Add("SequenceOfInput" + i.ToString())
                .SubItems.Add(G_Transaction.Inputs(i).Sequence)
            End With

        Next

        With LV_Transaction.Items.Add("Outputs")
            .SubItems.Add(G_Transaction.NumberOfOutputs)
        End With

        Dim NumberOfOutputs As ULong = HEXStringToULongList(G_Transaction.NumberOfOutputs)(0)
        For i As ULong = 0UL To NumberOfOutputs - 1UL

            With LV_Transaction.Items.Add("AmountNQTOfOutput" + i.ToString())
                .SubItems.Add(G_Transaction.Outputs(i).AmountNQT)
            End With

            With LV_Transaction.Items.Add("ScriptLengthOfOutput" + i.ToString())
                .SubItems.Add(G_Transaction.Outputs(i).ScriptLength)
            End With

            With LV_Transaction.Items.Add("ScriptOfOutput" + i.ToString())
                .SubItems.Add(G_Transaction.Outputs(i).Script)
            End With

        Next

        With LV_Transaction.Items.Add("LockTime")
            .SubItems.Add(G_Transaction.LockTime)
        End With

        With LV_Transaction.Items.Add("HashCode")
            .SubItems.Add(G_Transaction.HashCode)
        End With

        LV_Transaction.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent)

#End Region

    End Sub
    Private Sub LV_Transaction_SelectedIndexChanged(sender As Object, e As EventArgs) Handles LV_Transaction.SelectedIndexChanged

        If LV_Transaction.SelectedItems.Count > 0 Then

            Dim Attribute As String = GetLVColNameFromSubItem(LV_Transaction, "Attribute", LV_Transaction.SelectedItems(0))

            If Attribute.Contains("ScriptOf") Then
                Dim Value As String = GetLVColNameFromSubItem(LV_Transaction, "Value", LV_Transaction.SelectedItems(0))

                Dim Script As List(Of ClsScriptEntry) = ConvertScriptStrToScriptEntries(Value)

#Region "set in LV"

                LV_Script.Items.Clear()
                For Each Sentry As ClsScriptEntry In Script

                    If Sentry.Key = ClsScriptEntry.E_OP_Code.Signature Then

                        If Sentry.ValueHex = "01" Then
                            Label11.Enabled = False
                            Bt_TXsignTransaction.Enabled = False
                        Else
                            Label11.Enabled = True
                            Bt_TXsignTransaction.Enabled = True
                        End If

                    Else

                        With LV_Script.Items.Add(Sentry.Key.ToString())
                            .SubItems.Add(Sentry.ValueHex)
                        End With

                    End If

                Next
                LV_Script.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent)

#End Region

            End If

        End If

    End Sub

    Private Sub Bt_AddToUnlockScripts_Click(sender As Object, e As EventArgs) Handles Bt_AddToUnlockScripts.Click

        Dim UnlockingScript As String = TB_UnlockingScript.Text
        UnlockingScript = "63a821028b284c2a930354d1117369d668ec3b34a6f8df96867f43870f3cc6c87cf139ee8876a9148562fc5e57b965f8a62deaafeee84a7fc457c1d6675cb27576a914ee1fa939aa9e66d3aa5d1f24f503063222e09a806888ac"

        With LV_UnlockScripts.Items.Add(UnlockingScript)
            .SubItems.Add(PubKeyToRipe160(UnlockingScript))
        End With

    End Sub

    Private Sub LV_UnlockScripts_SelectedIndexChanged(sender As Object, e As EventArgs) Handles LV_UnlockScripts.SelectedIndexChanged

        If LV_UnlockScripts.SelectedItems.Count > 0 Then

            Dim T_Script As String = GetLVColNameFromSubItem(LV_UnlockScripts, "Unlocking Script", LV_UnlockScripts.SelectedItems(0))
            Dim Script As List(Of ClsScriptEntry) = ConvertScriptStrToScriptEntries(T_Script)

#Region "set in LV"

            LV_UnlockScript.Items.Clear()
            For Each Sentry As ClsScriptEntry In Script

                With LV_UnlockScript.Items.Add(Sentry.Key.ToString())
                    .SubItems.Add(Sentry.ValueHex)
                End With

            Next
            LV_UnlockScript.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent)

#End Region

        End If

    End Sub

#End Region

#Region "Tool Functions"
    Function ConvertTXStrToTX(ByVal TransactionHEX As String) As S_Transaction

        If MessageIsHEXString(TransactionHEX) Then

            Dim TX As S_Transaction = New S_Transaction("")

            TX.Inputs = New List(Of S_Input)
            TX.Outputs = New List(Of S_Output)

            TX.Version = TransactionHEX.Remove(8)
            TransactionHEX = TransactionHEX.Substring(8)
            TX.NumberOfInputs = TransactionHEX.Remove(2)
            TransactionHEX = TransactionHEX.Substring(2)

            Dim NumberOfInputs As ULong = HEXStringToULongList(TX.NumberOfInputs)(0)
            For i As ULong = 0UL To NumberOfInputs - 1UL

                Dim Input As S_Input = New S_Input("")

                Input.Transaction = TransactionHEX.Remove(64)
                TransactionHEX = TransactionHEX.Substring(64)

                Input.OutputIDX = TransactionHEX.Remove(8)
                TransactionHEX = TransactionHEX.Substring(8)

                Input.ScriptLength = TransactionHEX.Remove(2)
                TransactionHEX = TransactionHEX.Substring(2)

                Dim ScriptLength As ULong = HEXStringToULongList(Input.ScriptLength)(0)

                Input.Script = TransactionHEX.Remove(ScriptLength * 2)
                Input.InputScriptEntries = ConvertScriptStrToScriptEntries(Input.Script)
                TransactionHEX = TransactionHEX.Substring(ScriptLength * 2)

                Input.Sequence = TransactionHEX.Remove(8)
                TransactionHEX = TransactionHEX.Substring(8)

                TX.Inputs.Add(Input)

            Next

            TX.NumberOfOutputs = TransactionHEX.Remove(2)
            TransactionHEX = TransactionHEX.Substring(2)

            Dim NumberOfOutputs As ULong = HEXStringToULongList(TX.NumberOfOutputs)(0)

            For i As ULong = 0UL To NumberOfOutputs - 1UL

                Dim Output As S_Output = New S_Output("")

                Output.AmountNQT = TransactionHEX.Remove(16)
                TransactionHEX = TransactionHEX.Substring(16)

                Output.ScriptLength = TransactionHEX.Remove(2)
                TransactionHEX = TransactionHEX.Substring(2)

                Dim ScriptLength As ULong = HEXStringToULongList(Output.ScriptLength)(0)

                Output.Script = TransactionHEX.Remove(ScriptLength * 2)
                Output.OutputScriptEntries = ConvertScriptStrToScriptEntries(Output.Script)
                TransactionHEX = TransactionHEX.Substring(ScriptLength * 2)

                TX.Outputs.Add(Output)

            Next

            TX.LockTime = TransactionHEX.Substring(0, 8)
            TransactionHEX = TransactionHEX.Substring(8)

            If TransactionHEX.Length > 0 Then
                TX.HashCode = TransactionHEX
            Else
                TX.HashCode = ""
            End If

            Return TX

        End If

        Return Nothing

    End Function
    Function ConvertScriptStrToScriptEntries(ByVal Value As String) As List(Of ClsScriptEntry)

        Dim Script As List(Of ClsScriptEntry) = New List(Of ClsScriptEntry)

        Dim DER_Prefix As String = Value.Substring(6, 4)
        If DER_Prefix = "0220" Or DER_Prefix = "0221" Then
            'already signed

            Script.Add(New ClsScriptEntry(ClsScriptEntry.E_OP_Code.Signature, "01"))

            Script.Add(New ClsScriptEntry(ClsScriptEntry.E_OP_Code.DER_Prefix, Value.Remove(10)))
            Value = Value.Substring(10)

            Dim R_Length As ULong = HEXStringToULongList(DER_Prefix.Substring(2))(0)

            Script.Add(New ClsScriptEntry(ClsScriptEntry.E_OP_Code.R_Value, Value.Remove(R_Length * 2)))
            Value = Value.Substring(R_Length * 2)

            Dim DER_Split As String = Value.Remove(4)
            If DER_Split = "0220" Or DER_Split = "0221" Then

                Script.Add(New ClsScriptEntry(ClsScriptEntry.E_OP_Code.DER_Split, DER_Split))
                Value = Value.Substring(4)

                Dim S_Length As ULong = HEXStringToULongList(DER_Split.Substring(2))(0)

                Script.Add(New ClsScriptEntry(ClsScriptEntry.E_OP_Code.S_Value, Value.Remove(S_Length * 2)))
                Value = Value.Substring(S_Length * 2)

            End If

            Script.Add(New ClsScriptEntry(ClsScriptEntry.E_OP_Code.DER_End))
            Value = Value.Substring(2) 'DER_END

            Dim PubKeyLength As ULong = HEXStringToULongList(Value.Remove(2))(0)
            Value = Value.Substring(2) 'pubkeylength

            If PubKeyLength * 2 = Value.Length Then
                Script.Add(New ClsScriptEntry(ClsScriptEntry.E_OP_Code.PublicKey, Value))
            End If

        Else
            'unsigned

            Script.Add(New ClsScriptEntry(ClsScriptEntry.E_OP_Code.Signature, "00"))
            Script = ConvertLockingScriptStrToList(Value)
        End If

        Return Script

    End Function

#End Region

    ''' <summary>
    ''' Von einer ListView das subitem aus dem item lesen
    ''' </summary>
    ''' <param name="LV">Die ListView, aus der gelesen werden soll</param>
    ''' <param name="ColName">Der Spaltenname, aus dem gelesen werden soll</param>
    ''' <param name="LVItem">Die Zeile bzw. das item aus dem gelesen werden soll</param>
    ''' <param name="index">Alternativ das item an index stelle in der ListView</param>
    ''' <returns>Vorzugsweise einen String, andernfalls den index der Spalte</returns>
    ''' <remarks></remarks>
    Function GetLVColNameFromSubItem(ByRef LV As ListView, ByVal ColName As String, Optional ByVal LVItem As ListViewItem = Nothing, Optional ByVal index As Integer = -1) As Object

        If index > -1 Then
            LVItem = LV.Items.Item(index)
        End If

        If LVItem Is Nothing Then

            For i As Integer = 0 To LV.Columns.Count - 1
                Dim col As String = LV.Columns.Item(i).Text
                If col = ColName Then
                    Return i
                End If
            Next

        Else

            For i As Integer = 0 To LV.Columns.Count - 1
                Dim col As String = LV.Columns.Item(i).Text
                If col = ColName Then
                    Return LVItem.SubItems.Item(i).Text
                End If
            Next

        End If

        Return -1

    End Function

    Private Sub Bt_TXsignTransaction_Click(sender As Object, e As EventArgs) Handles Bt_TXsignTransaction.Click

        Dim SecretKeys As List(Of S_PrivateKey) = New List(Of S_PrivateKey)
        Dim T_Addresses As List(Of S_Address) = New List(Of S_Address)

        If LV_SignKeyPairs.Items.Count = 0 Then
            MsgBox("no addresses",, "error")
            Exit Sub
        End If

        For Each LVI As ListViewItem In LV_SignKeyPairs.Items

            Dim T_SecretKeys As List(Of String) = LVI.Tag.ToString().Split(";").ToList()
            SecretKeys.Add(New S_PrivateKey(T_SecretKeys(0), T_SecretKeys(1)))

            Dim PubKey As PublicKey = Secp256k1.CreatePublicKey(HEXStringToByteArray(T_SecretKeys(0)))
            Dim PublicKeyStr As String = ByteArrayToHEXString(PubKey.Serialize(True))
            Dim RIPE160 As String = PubKeyToRipe160(PublicKeyStr)
            Dim Address As String = RIPE160ToAddress(RIPE160, BitcoinAddressPrefix)

            T_Addresses.Add(New S_Address(Address, T_SecretKeys(1).Trim() <> ""))

        Next

        Dim RedeemScripts As List(Of String) = New List(Of String)

        For Each LVI As ListViewItem In LV_UnlockScripts.Items
            Dim UnlockScript As String = GetLVColNameFromSubItem(LV_UnlockScripts, "Unlocking Script", LVI)
            RedeemScripts.Add(UnlockScript)
        Next

        Dim Inputs As List(Of ClsUnspentOutput) = ConvertInputs(G_Transaction.Inputs, RedeemScripts)
        Dim Outputs As List(Of ClsOutput) = ConvertOutputs(G_Transaction.Outputs)

        Dim Balance As ULong = Convert.ToUInt64(Outputs.Select(Function(Output) Output.AmountNQT).ToList().Sum(Function(AmountNQT) AmountNQT))
        Balance /= Inputs.Count

        For i As Integer = 0 To Inputs.Count - 1
            Dim C_Input As ClsUnspentOutput = Inputs(i)
            C_Input.Addresses = T_Addresses.Select(Function(AddressEntry) AddressEntry.Address).ToList()
            C_Input.AmountNQT = Balance
            Inputs(i) = C_Input
        Next

        Dim Transaction As ClsBitcoinTransaction = New ClsBitcoinTransaction(Inputs, Outputs, T_Addresses)
        Transaction.SignTransaction(SecretKeys)

        If Transaction.Inputs.Count > 0 Then
            TB_TXSignedTransactionBytes.Text = Transaction.SignedTransactionHEX
        Else
            MsgBox("one or more inputs do not match a address",, "error")
        End If

    End Sub

    Private Function ConvertInputs(ByVal SInputs As List(Of S_Input), Optional ByVal RedeemScripts As List(Of String) = Nothing) As List(Of ClsUnspentOutput)

        Dim Inputs As List(Of ClsUnspentOutput) = New List(Of ClsUnspentOutput)

        For Each InputEntry As S_Input In SInputs

            Dim T_PrevTX As ClsUnspentOutput = New ClsUnspentOutput
            T_PrevTX.TransactionID = InputEntry.Transaction
            T_PrevTX.OutputType = AbsClsOutputs.E_Type.Unknown
            T_PrevTX.Confirmations = -1

            T_PrevTX.AmountNQT = Convert.ToUInt64(0UL)
            T_PrevTX.InputIndex = CInt(HEXStringToULongList(InputEntry.OutputIDX)(0))

            Dim T_LockingScript As String = InputEntry.Script
            T_PrevTX.ScriptHex = T_LockingScript
            T_PrevTX.LengthOfScript = Convert.ToInt32(T_LockingScript.Length / 2)
            T_PrevTX.Script = ConvertLockingScriptStrToList(T_LockingScript)
            T_PrevTX.OutputType = GetScriptType(T_LockingScript)

            If Not IsNothing(RedeemScripts) Then

                For Each RedeemScript In RedeemScripts

                    Dim T_RedeemScriptHash As String = PubKeyToRipe160(RedeemScript)

                    If T_LockingScript.Contains(T_RedeemScriptHash) Then
                        If T_PrevTX.OutputType = AbsClsOutputs.E_Type.Pay2ScriptHash Then
                            T_PrevTX.LengthOfScript = Convert.ToInt32(RedeemScript.Length / 2)
                            T_PrevTX.Script = ConvertLockingScriptStrToList(RedeemScript)
                            Dim T_SenderAddress As String = GetXFromScript(T_PrevTX.Script, ClsScriptEntry.E_OP_Code.RIPE160Sender)
                            T_SenderAddress = RIPE160ToAddress(T_SenderAddress, BitcoinAddressPrefix)
                            Dim T_RecipientAddress As String = GetXFromScript(T_PrevTX.Script, ClsScriptEntry.E_OP_Code.RIPE160Recipient)
                            T_RecipientAddress = RIPE160ToAddress(T_RecipientAddress, BitcoinAddressPrefix)

                            T_PrevTX.Addresses = New List(Of String)({T_RecipientAddress, T_SenderAddress})

                            T_PrevTX.ScriptHex = RedeemScript
                            T_PrevTX.ScriptHash = PubKeyToRipe160(RedeemScript)
                        End If
                    End If

                Next

            End If


            If T_PrevTX.OutputType = AbsClsOutputs.E_Type.Unknown Then
                T_PrevTX.OutputType = AbsClsOutputs.E_Type.Standard
            End If

            T_PrevTX.Spendable = True
            Inputs.Add(T_PrevTX)

        Next

        Return Inputs

    End Function

    Private Function ConvertOutputs(ByVal SOutputs As List(Of S_Output), Optional ByVal Addresses As List(Of String) = Nothing) As List(Of ClsOutput)

        Dim Outputs As List(Of ClsOutput) = New List(Of ClsOutput)

        For i As Integer = 0 To SOutputs.Count - 1

            Dim OutputEntry As S_Output = SOutputs(i)
            Dim T_Output As ClsOutput = New ClsOutput(OutputEntry.OutputScriptEntries)

            T_Output.AmountNQT = HEXStringToULongList(ChangeHEXStrEndian(OutputEntry.AmountNQT))(0)
            T_Output.Addresses = Addresses
            T_Output.Spendable = True
            T_Output.ChangeOutput = i = SOutputs.Count - 1
            T_Output.OutputType = GetScriptType(OutputEntry.Script)
            T_Output.ScriptHash = If(T_Output.OutputType = AbsClsOutputs.E_Type.Pay2ScriptHash, OutputEntry.Script, PubKeyToRipe160(OutputEntry.Script))
            Outputs.Add(T_Output)

        Next

        Return Outputs

    End Function

    Private Sub ChBx_Testnet_CheckedChanged(sender As Object, e As EventArgs) Handles ChBx_Testnet.CheckedChanged

        If ChBx_Testnet.Checked Then
            BitcoinAddressPrefix = "6f"
        Else
            BitcoinAddressPrefix = "00"
        End If

    End Sub

End Class
