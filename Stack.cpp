/* Data Structuer C++**/
#include<iostream>
#define Size 5
using namespace std;
//Add Items in Stack
class Stack{
 public :
  int Arr[Size];
  int Top;
  Stack(){
  	Top=-1;
  }
  // Add Items In Stack
  void Add_Items(int Number){
  	if(Top!=Size){
	  	Top++;
	  	Arr[Top]=Number;
	  }else{
  		cout<<"Stack Is Fully!"<<"\n";
  	}
  }
  // Delete Items From Stack
  void Delete(){
   if(Top==-1){
   	cout<<"Stack Is Empty!"<<"\n";
   }else{
   		Arr[Top--];
   }
  
  }
//Print Stack
	void print(){
		if(Top!=-1){
			for(int i=Top;i>=0;i--){
				cout<<Arr[i]<<"\n";
				}
			}else{
				cout<<"Can Not Print"<<"\n";
			}
		}
	
	   
};
int	 main(){
 	Stack S1;
 	S1.Add_Items(10);
	S1.Add_Items(20);
	S1.Add_Items(30);
 	S1.Add_Items(40);
 	S1.Add_Items(50);
 	S1.Delete();
 	S1.Delete();
 	S1.Delete();
 	S1.print();
 	return 0;
}