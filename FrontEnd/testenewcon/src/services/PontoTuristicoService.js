import axios from 'axios';

const PONTOTURISTICO_API_BASE_URL = "https://localhost:5001/api/PontoTuristico";

class PontoTuristicoService {

    getEmployees(){
        return axios.get(PONTOTURISTICO_API_BASE_URL);
    }

    createPontoTuristico(pontoturistico){
        return axios.post(PONTOTURISTICO_API_BASE_URL, pontoturistico);
    }

}

export default new PontoTuristicoService()