# Gestionale Azienda

<p>Applicativo per la gestione della produzione di un azienda  :factory:</p> 

## Funzionamento  :pushpin: 
 L'utente addetto al caricamento degli ordini, dopo aver eseguito l'accesso al server tramite username e password, potrà:
<ul>
  <li>Inserire gli ordini, inserendo: il codice dell'articolo, la quantità da produrre e la data entro la quale i pezzi dovranno essere prodotti;</li>
  <li>Eliminare un ordine, selezionandolo dall'apposita lista e premendo successivamente il tasto "Rimuovi".</li>
</ul>
  <p>L'utente addetto alla produzione, in modo analogo all'utente addetto al caricamento, dopo una fase di login potrà accedere all'interfaccia per la gestione della produzone dove potrà modificare la produzione e inserire i dati riguardanti la sua produzione, inserendo il nome dell'operatore, la macchina utilizzata e il numero di pezzi prodotti. Successivamente una volta selezionato dalla lista l'ordine, tramite il pulsante carica verranno invitati i dati al server.<br></p>
  
Il server una volta acquisiti i dati inviati dai vari utenti provvederà ad eseguire tutti i calcoli neccessari per l'aggiornamento dei dati.

## Architettura ⚙️
<p> Server: riceve le richieste da parte dei client ed esegue i calcoli necessari</p>
<p> Client: Mandano richieste al server e visualizza le risposte (Possono essere più di uno)</p>


### Utenti :information_desk_person:
| ID  | Nome               | Descrizione                                                |
| --- | ------------------ | ---------------------------------------------------------- |
| U1  | Utente macchina    | Addetto al caricamento dei dati di produzione              |
| U2  | Utente gestionale  | Adetto al caricamento o alla cancellazione di nuovi ordini |

### Funzionalità
  
| ID  | Nome                | Utenti   |     Descrizione                                            |
| --- | ------------------- | -------- | ---------------------------------------------------------- |
| F1  |  Send               |   U1,U2  | Manda i dati contenuti all'interno del database            |
| F2  |  ModificaOrdine     |   U1     | Sottrae i pezzi prodotti dal totale                        |
| F3  |  WriteAllFile       |   U1,U2  | Modifica i dati all'interno del database                   |
| F4  |  Login              |   U1,U2  | Controlla se i dati di login inseriti sono validi          |
| F5  |  Add                |   U2     | Aggiunge un ordine alla lista                              |
| F6  |  Remove             |   U2     | rimuove un ordine dalla lista                              |
 




