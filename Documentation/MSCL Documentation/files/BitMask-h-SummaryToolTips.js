NDSummary.OnToolTipsLoaded("File:BitMask.h",{4765:"<div class=\"NDToolTip TClass LC\"><div class=\"NDClassPrototype\" id=\"NDClassPrototype4765\"><div class=\"CPEntry TClass Current\"><div class=\"CPName\">BitMask</div></div></div><div class=\"TTSummary\">Represents a bitmask.</div></div>",4767:"<div class=\"NDToolTip TVariable LC\"><div id=\"NDPrototype4767\" class=\"NDPrototype NoParameterForm\"><span class=\"SHKeyword\">uint8</span> m_numBits</div><div class=\"TTSummary\">The number of bits that are being represented in the bitmask.</div></div>",4768:"<div class=\"NDToolTip TVariable LC\"><div id=\"NDPrototype4768\" class=\"NDPrototype NoParameterForm\">std::vector&lt;<span class=\"SHKeyword\">bool</span>&gt; m_mask</div><div class=\"TTSummary\">An array of bools holding the bitmask.</div></div>",4770:"<div class=\"NDToolTip TFunction LC\"><div id=\"NDPrototype4770\" class=\"NDPrototype WideForm CStyle\"><table><tr><td class=\"PBeforeParameters\"><span class=\"SHKeyword\">explicit</span> BitMask(</td><td class=\"PParametersParentCell\"><table class=\"PParameters\"><tr><td class=\"PType first\"><span class=\"SHKeyword\">uint16</span>&nbsp;</td><td class=\"PName last\">val</td></tr></table></td><td class=\"PAfterParameters\">)</td></tr></table></div><div class=\"TTSummary\">Creates an BitMask object given a uint16 value.</div></div>",4771:"<div class=\"NDToolTip TFunction LC\"><div id=\"NDPrototype4771\" class=\"NDPrototype NoParameterForm\">BitMask()</div><div class=\"TTSummary\">The default constructor for creating a BitMask object, which sets all the bits to inactive.</div></div>",4773:"<div class=\"NDToolTip TOperator LC\"><div class=\"TTSummary\">Equal operator for comparing BitMasks.</div></div>",4774:"<div class=\"NDToolTip TOperator LC\"><div class=\"TTSummary\">Not Equal operator for comparing BitMasks.</div></div>",4775:"<div class=\"NDToolTip TOperator LC\"><div class=\"TTSummary\">Less Than operator for comparing BitMasks.</div></div>",4776:"<div class=\"NDToolTip TOperator LC\"><div class=\"TTSummary\">Greater Than operator for comparing BitMasks.</div></div>",4778:"<div class=\"NDToolTip TFunction LC\"><div id=\"NDPrototype4778\" class=\"NDPrototype WideForm CStyle\"><table><tr><td class=\"PBeforeParameters\"><span class=\"SHKeyword\">virtual void</span> fromMask(</td><td class=\"PParametersParentCell\"><table class=\"PParameters\"><tr><td class=\"PType first\"><span class=\"SHKeyword\">uint16</span>&nbsp;</td><td class=\"PName last\">val</td></tr></table></td><td class=\"PAfterParameters\">)</td></tr></table></div><div class=\"TTSummary\">Initializes the BitMask object from a uint16.</div></div>",4779:"<div class=\"NDToolTip TFunction LC\"><div id=\"NDPrototype4779\" class=\"NDPrototype NoParameterForm\"><span class=\"SHKeyword\">virtual uint16</span> toMask() <span class=\"SHKeyword\">const</span></div><div class=\"TTSummary\">Gets the uint16 value of the current BitMask object.</div></div>",4780:"<div class=\"NDToolTip TFunction LC\"><div id=\"NDPrototype4780\" class=\"NDPrototype NoParameterForm\"><span class=\"SHKeyword\">virtual uint8</span> enabledCount() <span class=\"SHKeyword\">const</span></div><div class=\"TTSummary\">Gets the total number of enabled bits in the current BitMask object.</div></div>",4781:"<div class=\"NDToolTip TFunction LC\"><div id=\"NDPrototype4781\" class=\"NDPrototype WideForm CStyle\"><table><tr><td class=\"PBeforeParameters\"><span class=\"SHKeyword\">virtual bool</span> enabled(</td><td class=\"PParametersParentCell\"><table class=\"PParameters\"><tr><td class=\"PType first\"><span class=\"SHKeyword\">uint8</span>&nbsp;</td><td class=\"PName last\">bitIndex</td></tr></table></td><td class=\"PAfterParameters\">) <span class=\"SHKeyword\">const</span></td></tr></table></div><div class=\"TTSummary\">Checks whether a certain bit is enabled or disabled.</div></div>",4782:"<div class=\"NDToolTip TFunction LC\"><div id=\"NDPrototype4782\" class=\"NDPrototype WideForm CStyle\"><table><tr><td class=\"PBeforeParameters\"><span class=\"SHKeyword\">virtual void</span> enable(</td><td class=\"PParametersParentCell\"><table class=\"PParameters\"><tr><td class=\"PType first\"><span class=\"SHKeyword\">uint8</span>&nbsp;</td><td class=\"PName\">bitIndex,</td><td></td><td class=\"last\"></td></tr><tr><td class=\"PType first\"><span class=\"SHKeyword\">bool</span>&nbsp;</td><td class=\"PName\">enable&nbsp;</td><td class=\"PDefaultValueSeparator\">=&nbsp;</td><td class=\"PDefaultValue last\"><span class=\"SHKeyword\">true</span></td></tr></table></td><td class=\"PAfterParameters\">)</td></tr></table></div><div class=\"TTSummary\">Enables or disables a specified bit.</div></div>",4783:"<div class=\"NDToolTip TFunction LC\"><div id=\"NDPrototype4783\" class=\"NDPrototype NoParameterForm\"><span class=\"SHKeyword\">virtual int16</span> lastBitEnabled() <span class=\"SHKeyword\">const</span></div><div class=\"TTSummary\">Finds the highest bit that is enabled in the mask.&nbsp; This is useful when looping over the BitMask object and performing an action on all enabled bits.</div></div>"});