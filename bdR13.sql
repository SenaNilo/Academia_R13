create database bd_r13academia;

use bd_r13academia;

create table tb_datas(
id_data int(200) not null auto_increment,
ult_pagamento date not null,
prx_pagamento date,
primary key(id_data)
)default charset utf8;

create table tb_marombas(
id_maromba int(5) not null auto_increment,
nm_maromba varchar(250) not null,
id_data int(200) not null,
primary key (id_maromba),
foreign key(id_data) references tb_datas(id_data)
)default charset utf8;

/* Trigger - Próximo pagamento a ser efetuado */
delimiter $
	create trigger trProxPagamento
		before insert on tb_datas
			for each row 
				begin
					set new.prx_pagamento = (select date_add(new.ult_pagamento, interval 1 month));
				end $
                
/* Update */
delimiter $
	create trigger trProxPagamentoUp
		before update on tb_datas
			for each row 
				begin
					set new.prx_pagamento = (select date_add(new.ult_pagamento, interval 1 month));
				end $

/* Procedures */
delimiter $
create procedure cadMarombas(
in maromba varchar(250), /* O que vai ser utilizado para atualizar os dados */
in ultimoPag date)
begin
	declare idData int;
	insert into tb_datas(ult_pagamento) values(ultimoPag);
    set idData = (select max(id_data) from tb_datas);
    insert into tb_marombas(nm_maromba, id_data) values(maromba, idData);
end $

/* Inserts */
/*insert into tb_marombas (nm_maromba) values 
("Antônio Vieira dos Santos"),
("Lucas Sena Rezende"),
("Gustavo Vieira dos Santos"),
("Antony Silva Sena");

insert into tb_datas (ult_pagamento) values 
("2023-02-01"),
("2022-12-30"),
("2023-01-01"),
("2023-01-13");

insert into tb_pagamento (sts_pagamento, id_maromba, id_data) values
('pago', 1, 1),
('npag', 2, 2),
('pago', 3, 3),
('pago', 4, 4);*/


/* Selects de teste para colocar no codigo */    
/* Clientes que pagaram */
select ma.nm_maromba, dt.ult_pagamento as UltimoPag, dt.prx_pagamento as ProximoPag 
    from tb_marombas as ma 
		inner join tb_datas as dt on (dt.id_data = ma.id_data) 
			where dt.prx_pagamento > curdate();


/* Clientes que n pagaram */
select ma.nm_maromba, dt.ult_pagamento as UltimoPag, dt.prx_pagamento as ProximoPag 
    from tb_marombas as ma 
		inner join tb_datas as dt on (dt.id_data = ma.id_data) 
			where dt.prx_pagamento <= curdate();
