CREATE OR REPLACE FUNCTION public.update_developer(
	d_id integer,
	d_nama character varying,
	d_proyek_id integer,
	d_status_kontrak character varying,
	d_fitur_selesai integer,
	d_jumlah_bug integer
) RETURNS void
LANGUAGE plpgsql
AS $function$
BEGIN
	UPDATE developer
	SET
		nama = d_nama,
		proyek_id = d_proyek_id,
		status_kontrak = d_status_kontrak,
		fitur_selesai = d_fitur_selesai,
		jumlah_bug = d_jumlah_bug
	WHERE id = d_id;
END;
$function$