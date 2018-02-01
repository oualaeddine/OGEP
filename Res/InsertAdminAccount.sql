
if not exists 
(select * from UserTypes where descr = 'ADMIN')
   insert 
   into UserTypes
    (descr) 
	values
	('ADMIN');
	
if not exists 
(select * from Users where username = 'ADMIN')
   insert 
   into Users
    ([username],[Password],[type]) 
	values
	('ADMIN','ADMIN',1)