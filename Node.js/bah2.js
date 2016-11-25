/**
 * Created by Bhajian on 7/7/2016.
 */
var express=require('express');
var app=express();

var mysql=require('mysql');
var connection=mysql.createConnection({
    host:'localhost',
    user:'root',
    password:'100'
});
app.get('/bah',function(req,res){
    readDataMysql(function(data){
        res.json(JSON.stringify(data));
       //res.send(data);
    });
});
app.get('/',function (req,res) {
    res.send('Hello World');

});
app.listen(3000,function (){
    console.log('The web server is running on port 3000.......');


});

function readDataMysql(cb) {
    connection.query('select * from bah.person',function (err,rows,fields) {
        if(err)throw err;
        cb(rows);
    });
}