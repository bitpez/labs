import type { NextPage } from 'next'
import Head from 'next/head'
import Image from 'next/image'
import Link from 'next/link'
import styles from '../../styles/Home.module.css'
 
const Core: NextPage = () => {
  
  const callAPI = async () => {
    try {
        const res = await fetch(
            `/api/products`,
            {
                method: 'GET',
                headers: {
                   
                },
            }
        );
        const data = await res.json();
        console.log(data);
    } catch (err) {
        console.log(err);
    }
};
return (
    <div className={styles.container}>
        <main className={styles.main}>
            <button onClick={callAPI}>Make API call</button>
        </main>
    </div>
);
  
};

export default Core
