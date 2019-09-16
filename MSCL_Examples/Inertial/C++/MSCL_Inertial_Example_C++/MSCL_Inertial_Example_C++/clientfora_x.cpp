#include <iostream>
using namespace std;

#include<mscl/mscl.h>

#include"getCurrentConfig.h"
#include"parseData.h"
#include"setCurrentConfig.h"
#include"startSampling.h"
#include"setToIdle.h"
#include<arpa/inet.h>
#include<sys/socket.h>
#include<unistd.h>
#include<ctime>
#include<string.h>

#define SERVER "127.0.0.1"
#define BUFLEN 512	//Max length of buffer
#define PORT 8888	//The port on which to send data

void die(char const *s)
{
	perror(s);
	exit(1);
}



int main(int argc, char **argv)
{
    // Generating a client server
    struct sockaddr_in si_other;
	int s, i;
	socklen_t slen=sizeof(si_other);
	char buf[BUFLEN];
	string message_str;
	

	if ( (s=socket(AF_INET, SOCK_DGRAM, IPPROTO_UDP)) == -1)
	{
		die("socket");
	}

	memset((char *) &si_other, 0, sizeof(si_other));
	si_other.sin_family = AF_INET;
	si_other.sin_port = htons(PORT);
	
	if (inet_aton(SERVER , &si_other.sin_addr) == 0) 
	{
		fprintf(stderr, "inet_aton() failed\n");
		exit(1);
	}
	
	// creating the client server done
    
    
    
    
    
    //TODO: change these constants to match your setup
    const string COM_PORT = "/dev/ttyACM1";

    try
    {
        //create a SerialConnection with the COM port
        mscl::Connection connection = mscl::Connection::Serial(COM_PORT, 115200);

        //create an InertialNode with the connection
        mscl::InertialNode node(connection);

        cout << "Node Information: " << endl;
        cout << "Model Name: " << node.modelName() << endl;
        cout << "Model Number: " << node.modelNumber() << endl;
        cout << "Serial: " << node.serialNumber() << endl;
        cout << "Firmware: " << node.firmwareVersion().str() << endl << endl;

        //TODO: Uncomment the lines below to run the examples

        //Example: Get Configuration
        //cout << "printing the current configuration";
        //getCurrentConfig(node);

        //Example: Set Configuration
        //setCurrentConfig(node);       //Warning: this example changes settings on your Node!

        //Example: Start Sampling
        startSampling(node);
        
        //Example: Set to Idle
        //setToIdle(node);

        //Example: Parse Data
         
        
        while(true)
    	{
        //get all the data packets from the node, with a timeout of 500 milliseconds
        mscl::MipDataPackets packets = node.getDataPackets(500);

        	for(mscl::MipDataPacket packet : packets)
        	{
            //print out the data
            cout << "Packet Received: ";

            //get the data in the packet
            mscl::MipDataPoints data = packet.data();
            mscl::MipDataPoint dataPoint;

            //record only from one channel here a_x from data points in the packet
            
                dataPoint = data[0];

                cout << dataPoint.channelName() << ": ";
				cout << dataPoint.as_string() ;
                //print out the channel data
                //Note: The as_string() function is being used here for simplicity. 
                //      Other methods (ie. as_float, as_uint16, as_Vector) are also available.
                //      To determine the format that a dataPoint is stored in, use dataPoint.storedAs().
                message_str = dataPoint.as_string() ;
				//cout << dataPoint.storedAs() << " " ;
                //if the dataPoint is invalid
                //cout << dataPoint.valid() << " ";
                
                // converting the string to a const char*
                const char* message_char = message_str.c_str();
                
                // Sending the data via client on the port
                sendto(s, message_char, strlen(message_char), 0, (struct sockaddr *) &si_other, slen);
                
                	if(!dataPoint.valid())
                	{
                    cout << "[Invalid] ";
                	}
            	}
            cout << endl;
        }
    }
    catch(mscl::Error& e)
    {
        cout << "Error: " << e.what() << endl;
    }
        
      
     
    
    
    
    
    
    
	close(s);
    system("pause");
    return 0;  
        
}
            
    

