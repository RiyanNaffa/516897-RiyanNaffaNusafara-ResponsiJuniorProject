CREATE OR REPLACE FUNCTION public.insert_developer(
	d_nama character varying,
	d_proyek_id integer,
	d_status_kontrak character varying,
	d_fitur_selesai integer,
	d_jumlah_bug integer
) RETURNS void
LANGUAGE plpgsql
AS $function$
BEGIN
	INSERT INTO developer (
		nama, proyek_id, status_kontrak, fitur_selesai, jumlah_bug
	) VALUES (d_nama, d_proyek_id, d_status_kontrak, d_fitur_selesai, d_jumlah_bug);
END;
$function$