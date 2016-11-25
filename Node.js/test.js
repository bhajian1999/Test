function placeorder(orderNumber){

console.log('the order number is : ',orderNumber);

cookAndDeliver(function(){
console.log('delivery number is: ',orderNumber);
});

}


function cookAndDeliver(callback){

    setTimeout(callback,5000);

}


placeorder(1);
placeorder(2);
placeorder(3);
placeorder(4);
placeorder(5);
placeorder(6);