using api.interfaces;
using api.models;
using System.Collections.Generic;


namespace api.data_access
{
    public class StoreDataHandlerTest: IStoreDataHandler
    {
        public List<Store> GetAllStores(){
            List<Store> myStores = new List<Store>();
            myStores.Add(new Store(){id = 1, 
                                    addressLineOne = "123 Dirt Rd",
                                    addressLineTwo = "",
                                    city = "Clanton",
                                    state = "Alabama",
                                    zip = 35045});
            myStores.Add(new Store(){id = 1, 
                                    addressLineOne = "123 Paved Rd",
                                    addressLineTwo = "",
                                    city = "Colleyville",
                                    state = "Texas",
                                    zip = 76034});
            myStores.Add(new Store(){id = 1, 
                                    addressLineOne = "123 Bumpy Rd",
                                    addressLineTwo = "Box 1330",
                                    city = "Tuscaloosa",
                                    state = "Alabama",
                                    zip = 35404});
            return myStores;
        }
        public Store GetStore(int id){
            return new Store();
        }
        public void UpdateStore(Store value){

        }
        public void CreateStore(Store value){

        }
        public void DeleteStore(int id){

        }
    }
}