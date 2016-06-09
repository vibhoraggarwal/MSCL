NDSummary.OnToolTipsLoaded("CClass:Connection_Impl",{73:"<div class=\"NDToolTip TClass LC\"><div class=\"NDClassPrototype\" id=\"NDClassPrototype73\"><div class=\"CPEntry TClass Current\"><div class=\"CPModifiers\"><span class=\"SHKeyword\">template</span> &lt;typename Comm_Object&gt;</div><div class=\"CPName\">Connection_Impl</div></div></div><div class=\"TTSummary\">An Abstract Base Class for various connection types.&nbsp; This class uses a template for the Comm Object and contains default functionality for connection types.</div></div>",75:"<div class=\"NDToolTip TFunction LC\"><div id=\"NDPrototype75\" class=\"NDPrototype NoParameterForm\"><span class=\"SHKeyword\">virtual</span> ~Connection_Impl()</div><div class=\"TTSummary\">Destroys the Connection_Impl object</div></div>",77:"<div class=\"NDToolTip TVariable LC\"><div id=\"NDPrototype77\" class=\"NDPrototype NoParameterForm\">std::unique_ptr&lt; BoostCommunication&lt;Comm_Object&gt; &gt; m_comm</div><div class=\"TTSummary\">A BoostCommunication object used for actual read/write operations.</div></div>",78:"<div class=\"NDToolTip TVariable LC\"><div id=\"NDPrototype78\" class=\"NDPrototype NoParameterForm\">std::unique_ptr&lt;boost::asio::io_service&gt; m_ioService</div><div class=\"TTSummary\">The boost::asio::io_service object.</div></div>",79:"<div class=\"NDToolTip TVariable LC\"><div id=\"NDPrototype79\" class=\"NDPrototype NoParameterForm\">std::unique_ptr&lt;Comm_Object&gt; m_ioPort</div><div class=\"TTSummary\">The actual boost communication object (ex. boost::asio::serial_port, tcp::socket, etc.)</div></div>",80:"<div class=\"NDToolTip TVariable LC\"><div id=\"NDPrototype80\" class=\"NDPrototype NoParameterForm\">std::unique_ptr&lt;std::thread&gt; m_readThread</div><div class=\"TTSummary\">The thread used to run the operation of reading in bytes from the BaseStation.</div></div>",81:"<div class=\"NDToolTip TVariable LC\"><div id=\"NDPrototype81\" class=\"NDPrototype NoParameterForm\"><span class=\"SHKeyword\">bool</span> m_established</div><div class=\"TTSummary\">true if the connection has been established, false otherwise.</div></div>",82:"<div class=\"NDToolTip TVariable LC\"><div id=\"NDPrototype82\" class=\"NDPrototype WideForm CStyle\"><table><tr><td class=\"PBeforeParameters\">std::<span class=\"SHKeyword\">function</span>&lt;<span class=\"SHKeyword\">void</span>(</td><td class=\"PParametersParentCell\"><table class=\"PParameters\"><tr><td class=\"PName first last\">DataBuffer&amp;</td></tr></table></td><td class=\"PAfterParameters\">)&gt; m_parseFunction</td></tr></table></div><div class=\"TTSummary\">The function to call to parse data that is read in.</div></div>",83:"<div class=\"NDToolTip TVariable LC\"><div id=\"NDPrototype83\" class=\"NDPrototype NoParameterForm\">boost::circular_buffer_space_optimized&lt;<span class=\"SHKeyword\">uint8</span>&gt; m_rawByteBuffer</div><div class=\"TTSummary\">The circular buffer to store data when in &quot;Raw Byte Mode.&quot;</div></div>",84:"<div class=\"NDToolTip TVariable LC\"><div id=\"NDPrototype84\" class=\"NDPrototype NoParameterForm\">std::condition_variable m_rawByteBufferCondition</div><div class=\"TTSummary\">Allows the raw byte buffer to know when data has been added.</div></div>",85:"<div class=\"NDToolTip TVariable LC\"><div id=\"NDPrototype85\" class=\"NDPrototype NoParameterForm\"><span class=\"SHKeyword\">bool</span> m_connectionError</div><div class=\"TTSummary\">true if an error has occurred with the connection, false otherwise.</div></div>",86:"<div class=\"NDToolTip TVariable LC\"><div id=\"NDPrototype86\" class=\"NDPrototype NoParameterForm\"><span class=\"SHKeyword\">int</span> m_errorCode</div><div class=\"TTSummary\">The error code of the connection error, if there was a connection error.</div></div>",87:"<div class=\"NDToolTip TVariable LC\"><div id=\"NDPrototype87\" class=\"NDPrototype NoParameterForm\">std::<span class=\"SHKeyword\">string</span> m_errorMsg</div><div class=\"TTSummary\">The error message of the connection error, if there was a connection error.</div></div>",88:"<div class=\"NDToolTip TVariable LC\"><div id=\"NDPrototype88\" class=\"NDPrototype NoParameterForm\"><span class=\"SHKeyword\">bool</span> m_rawByteMode</div><div class=\"TTSummary\">true if the connection is in &quot;Raw Byte Mode&quot;, false otherwise.</div></div>",89:"<div class=\"NDToolTip TVariable LC\"><div id=\"NDPrototype89\" class=\"NDPrototype NoParameterForm\">std::mutex m_rawDataMutex</div><div class=\"TTSummary\">The mutex used to access the &quot;Raw Byte Mode&quot; buffer.</div></div>",91:"<div class=\"NDToolTip TFunction LC\"><div id=\"NDPrototype91\" class=\"NDPrototype NoParameterForm\"><span class=\"SHKeyword\">virtual void</span> establishConnection() = <span class=\"SHNumber\">0</span></div><div class=\"TTSummary\">Initializes and opens the current connection.</div></div>",92:"<div class=\"NDToolTip TFunction LC\"><div id=\"NDPrototype92\" class=\"NDPrototype NoParameterForm\"><span class=\"SHKeyword\">virtual</span> std::<span class=\"SHKeyword\">string</span> description() = <span class=\"SHNumber\">0</span></div><div class=\"TTSummary\">Gets a description of the connection as a string.</div></div>",93:"<div class=\"NDToolTip TFunction LC\"><div id=\"NDPrototype93\" class=\"NDPrototype NoParameterForm\"><span class=\"SHKeyword\">virtual void</span> disconnect() <span class=\"SHKeyword\">override</span></div><div class=\"TTSummary\">Closes the current connection.</div></div>",94:"<div class=\"NDToolTip TFunction LC\"><div id=\"NDPrototype94\" class=\"NDPrototype NoParameterForm\"><span class=\"SHKeyword\">virtual void</span> reconnect() <span class=\"SHKeyword\">override</span></div><div class=\"TTSummary\">Reopens a connection that has been disconnected.</div></div>",95:"<div class=\"NDToolTip TFunction LC\"><div id=\"NDPrototype95\" class=\"NDPrototype WideForm CStyle\"><table><tr><td class=\"PBeforeParameters\"><span class=\"SHKeyword\">virtual void</span> registerParser(</td><td class=\"PParametersParentCell\"><table class=\"PParameters\"><tr><td class=\"PModifierQualifier first\">std::</td><td class=\"PType\"><span class=\"SHKeyword\">function</span>&lt;<span class=\"SHKeyword\">void</span>(DataBuffer&amp;)&gt;&nbsp;</td><td class=\"PName last\">parseFunction</td></tr></table></td><td class=\"PAfterParameters\">) <span class=\"SHKeyword\">final</span></td></tr></table></div><div class=\"TTSummary\">Registers a function to handle the parsing of data when it is read in.</div></div>",96:"<div class=\"NDToolTip TFunction LC\"><div id=\"NDPrototype96\" class=\"NDPrototype NoParameterForm\"><span class=\"SHKeyword\">virtual void</span> unregisterParser() <span class=\"SHKeyword\">final</span></div><div class=\"TTSummary\">Unregisters the function to handle the parsing of data when it is read in.</div></div>",97:"<div class=\"NDToolTip TFunction LC\"><div id=\"NDPrototype97\" class=\"NDPrototype NoParameterForm\"><span class=\"SHKeyword\">virtual void</span> throwIfError() <span class=\"SHKeyword\">final</span></div><div class=\"TTSummary\">Throws an exception if a connection error has occurred.</div></div>",98:"<div class=\"NDToolTip TFunction LC\"><div id=\"NDPrototype98\" class=\"NDPrototype WideForm CStyle\"><table><tr><td class=\"PBeforeParameters\"><span class=\"SHKeyword\">virtual void</span> write(</td><td class=\"PParametersParentCell\"><table class=\"PParameters\"><tr><td class=\"PModifierQualifier first\"><span class=\"SHKeyword\">const</span>&nbsp;</td><td class=\"PType\">ByteStream&nbsp;</td><td class=\"PNamePrefix\">&amp;</td><td class=\"PName last\">data</td></tr></table></td><td class=\"PAfterParameters\">) <span class=\"SHKeyword\">final</span></td></tr></table></div><div class=\"TTSummary\">Writes bytes to the port via the BoostCommunication object.</div></div>",99:"<div class=\"NDToolTip TFunction LC\"><div id=\"NDPrototype99\" class=\"NDPrototype WideForm CStyle\"><table><tr><td class=\"PBeforeParameters\"><span class=\"SHKeyword\">virtual void</span> write(</td><td class=\"PParametersParentCell\"><table class=\"PParameters\"><tr><td class=\"PModifierQualifier first\"><span class=\"SHKeyword\">const</span>&nbsp;</td><td class=\"PType\">Bytes&nbsp;</td><td class=\"PNamePrefix\">&amp;</td><td class=\"PName last\">bytes</td></tr></table></td><td class=\"PAfterParameters\">) <span class=\"SHKeyword\">final</span></td></tr></table></div><div class=\"TTSummary\">Writes the given bytes to the port via the BoostCommunication object.</div></div>",100:"<div class=\"NDToolTip TFunction LC\"><div id=\"NDPrototype100\" class=\"NDPrototype NoParameterForm\"><span class=\"SHKeyword\">virtual void</span> clearBuffer() <span class=\"SHKeyword\">final</span></div><div class=\"TTSummary\">Clears the read buffer.</div></div>",101:"<div class=\"NDToolTip TFunction LC\"><div id=\"NDPrototype101\" class=\"NDPrototype NoParameterForm\"><span class=\"SHKeyword\">virtual</span> std::size_t byteReadPos() <span class=\"SHKeyword\">const final</span></div><div class=\"TTSummary\">Gets the read position from the byte buffer.</div></div>",102:"<div class=\"NDToolTip TFunction LC\"><div id=\"NDPrototype102\" class=\"NDPrototype NoParameterForm\"><span class=\"SHKeyword\">virtual</span> std::size_t byteAppendPos() <span class=\"SHKeyword\">const final</span></div><div class=\"TTSummary\">Gets the append position from the byte buffer.</div></div>",103:"<div class=\"NDToolTip TFunction LC\"><div id=\"NDPrototype103\" class=\"NDPrototype NoParameterForm\"><span class=\"SHKeyword\">void</span> startIoThread()</div><div class=\"TTSummary\">Starts the main thread for reading in all the data and handling write commands</div></div>",104:"<div class=\"NDToolTip TFunction LC\"><div id=\"NDPrototype104\" class=\"NDPrototype NoParameterForm\"><span class=\"SHKeyword\">void</span> stopIoThread()</div><div class=\"TTSummary\">Stops the main thread, canceling all reading and writing</div></div>",105:"<div class=\"NDToolTip TFunction LC\"><div id=\"NDPrototype105\" class=\"NDPrototype WideForm CStyle\"><table><tr><td class=\"PBeforeParameters\"><span class=\"SHKeyword\">virtual void</span> rawByteMode(</td><td class=\"PParametersParentCell\"><table class=\"PParameters\"><tr><td class=\"PType first\"><span class=\"SHKeyword\">bool</span>&nbsp;</td><td class=\"PName last\">enable</td></tr></table></td><td class=\"PAfterParameters\">) <span class=\"SHKeyword\">final</span></td></tr></table></div><div class=\"TTSummary\">Puts the connection into &quot;Raw Byte Mode.&quot;  &quot;Raw Byte Mode&quot; stops the data from being sent/parsed from any attached devices (BaseStation, InertialNode, etc.)&nbsp; and instead sends all data into a raw circular data buffer that can be accessed by calling getRawBytes on this Connection object.&nbsp; Disabling this mode will start sending all data back to the previous attached device, if still available.</div></div>",106:"<div class=\"NDToolTip TFunction LC\"><div id=\"NDPrototype106\" class=\"NDPrototype WideForm CStyle\"><table><tr><td class=\"PBeforeParameters\"><span class=\"SHKeyword\">virtual void</span> getRawBytes(</td><td class=\"PParametersParentCell\"><table class=\"PParameters\"><tr><td class=\"PType first\">Bytes&nbsp;</td><td class=\"PNamePrefix\">&amp;</td><td class=\"PName\">bytes,</td><td></td><td class=\"last\"></td></tr><tr><td class=\"PType first\"><span class=\"SHKeyword\">uint32</span>&nbsp;</td><td></td><td class=\"PName\">timeout&nbsp;</td><td class=\"PDefaultValueSeparator\">=&nbsp;</td><td class=\"PDefaultValue last\"><span class=\"SHNumber\">0</span>,</td></tr><tr><td class=\"PType first\"><span class=\"SHKeyword\">uint32</span>&nbsp;</td><td></td><td class=\"PName\">maxBytes&nbsp;</td><td class=\"PDefaultValueSeparator\">=&nbsp;</td><td class=\"PDefaultValue last\"><span class=\"SHNumber\">0</span></td></tr></table></td><td class=\"PAfterParameters\">) <span class=\"SHKeyword\">final</span></td></tr></table></div><div class=\"TTSummary\">Gets all of the raw bytes that are available that have been collected when the Connection is in &quot;Raw Byte Mode.&quot;&nbsp; If the Connection has not been put into &quot;Raw Byte Mode&quot; by calling rawByteMode, no data can be retrieved from this function.</div></div>",107:"<div class=\"NDToolTip TFunction LC\"><div id=\"NDPrototype107\" class=\"NDPrototype WideForm CStyle\"><table><tr><td class=\"PBeforeParameters\"><span class=\"SHKeyword\">void</span> collectRawData(</td><td class=\"PParametersParentCell\"><table class=\"PParameters\"><tr><td class=\"PType first\">DataBuffer&nbsp;</td><td class=\"PNamePrefix\">&amp;</td><td class=\"PName last\">data</td></tr></table></td><td class=\"PAfterParameters\">)</td></tr></table></div><div class=\"TTSummary\">The function to be sent to the communication object to parse data for &quot;Raw Byte Mode.&quot;</div></div>"});